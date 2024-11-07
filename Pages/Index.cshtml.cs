using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using petrine.no.ViewModels;

namespace petrine.no.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProjectViewModel> LatestProjects { get; set; } = new List<ProjectViewModel>();

        // Hero section properties
        public string HeroImageUrl { get; set; } = "https://via.placeholder.com/1920x600";
        public string HeroTitle { get; set; } = "Welcome to Petrine.no!";
        public string HeroSubtitle { get; set; } = "Explore our projects and blog.";

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
            var specificRepos = new List<string> { "RettVest", "Repo2", "Repo3" }; // Ensure these match your actual repo names

            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MyApp", "1.0"));

            var token = Environment.GetEnvironmentVariable("GITHUB_TOKEN");

            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }

            foreach (var repo in specificRepos)
            {
                var url = $"https://api.github.com/repos/EPetrineLynghaug/{repo}";
                _logger.LogInformation("Fetching data from URL: {Url}", url);

                try
                {
                    var response = await client.GetAsync(url);
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
                        _logger.LogWarning("GitHub API returned a non-success status code: {StatusCode} for repo: {Repo}", response.StatusCode, repo);
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