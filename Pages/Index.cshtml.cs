using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using petrine.no.Models;

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
        using var client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MyPortfolioApp", "1.0"));

        try
        {
            var response = await client.GetAsync("https://api.github.com/users/EPetrineLynghaug/repos");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var repos = JsonSerializer.Deserialize<List<ProjectViewModel>>(responseContent) ?? new List<ProjectViewModel>();

                // Sort by CreatedAt in descending order and take the latest 3 projects
                LatestProjects = repos
                    .OrderByDescending(repo => repo.CreatedAt)
                    .Take(3)
                    .ToList();
            }
            else
            {
                _logger.LogWarning("GitHub API returned a non-success status code: {StatusCode}", response.StatusCode);
                LatestProjects = new List<ProjectViewModel>();
            }
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "An error occurred while fetching data from GitHub API.");
            LatestProjects = new List<ProjectViewModel>();
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "An error occurred while deserializing the GitHub API response.");
            LatestProjects = new List<ProjectViewModel>();
        }
    }
}