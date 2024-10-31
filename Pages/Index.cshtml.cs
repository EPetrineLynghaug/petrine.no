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
            // Ensure URL is formatted correctly
            var response = await client.GetAsync("https://api.github.com/users/EPetrineLynghaug/repos");

            // Check if response was successful
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var repos = JsonSerializer.Deserialize<List<ProjectViewModel>>(responseContent) ?? new List<ProjectViewModel>();

                LatestProjects = repos.Take(3).ToList();
            }
            else
            {
                _logger.LogWarning("GitHub API returned a non-success status code: {StatusCode}", response.StatusCode);
                LatestProjects = new List<ProjectViewModel>(); // Empty list on failure
            }
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "An error occurred while fetching data from GitHub API.");
            LatestProjects = new List<ProjectViewModel>(); // Empty list if there's a network error
        }
        catch (JsonException ex)
        {
            _logger.LogError(ex, "An error occurred while deserializing the GitHub API response.");
            LatestProjects = new List<ProjectViewModel>(); // Empty list if deserialization fails
        }
    }
}