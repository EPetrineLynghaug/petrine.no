using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using petrine.no.ViewModels;

namespace petrine.no.Pages
{
    public class ProjectDetailsModel : PageModel
    {
        private readonly ILogger<ProjectDetailsModel> _logger;

        public ProjectViewModel? Project { get; private set; }

        public ProjectDetailsModel(ILogger<ProjectDetailsModel> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> OnGetAsync(string repoName)
        {
            if (string.IsNullOrEmpty(repoName))
            {
                _logger.LogWarning("No repository name provided in the URL.");
                return NotFound();
            }

            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("MyPortfolioApp", "1.0"));

            try
            {
                var response = await client.GetAsync($"https://api.github.com/repos/EPetrineLynghaug/{repoName}");
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Project = JsonSerializer.Deserialize<ProjectViewModel>(responseContent);

                    if (Project == null)
                    {
                        _logger.LogWarning("Failed to deserialize project details.");
                        return NotFound();
                    }
                }
                else
                {
                    _logger.LogWarning("GitHub API returned a non-success status code: {StatusCode}", response.StatusCode);
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching data from GitHub API for repo {RepoName}.", repoName);
                return StatusCode(500, "Internal server error");
            }

            return Page();
        }
    }
}