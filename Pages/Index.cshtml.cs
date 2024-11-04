using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using petrine.no.ViewModels;

namespace petrine.no.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProjectViewModel> LatestProjects { get; set; } = new List<ProjectViewModel>();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            // Fetch projects from GitHub
            await FetchProjectsAsync();
        }

        private async Task FetchProjectsAsync()
        {
            var specificRepos = new List<string> { "RettVest", "Repo2", "Repo3" }; // Replace with actual repo names

            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MyApp", "1.0"));

            var token = Environment.GetEnvironmentVariable("GITHUB_TOKEN");

            // Add the token to the Authorization header if it's available
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            foreach (var repo in specificRepos)
            {
                try
                {
                    var response = await client.GetAsync($"https://api.github.com/repos/EPetrineLynghaug/{repo}");
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var project = JsonSerializer.Deserialize<ProjectViewModel>(responseContent);

                        if (project != null)
                        {
                            LatestProjects.Add(project);
                        }
                    }
                    else
                    {
                        _logger.LogWarning("GitHub API returned a non-success status code: {StatusCode}", response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while fetching data from GitHub API for repo {Repo}.", repo);
                }
            }
        }
    }
}