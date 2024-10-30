using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class IndexModel : PageModel
{
    public List<ProjectViewModel> LatestProjects { get; set; } = new List<ProjectViewModel>();

    public async Task OnGetAsync()
    {
        using var client = new HttpClient();
        var response = await client.GetStringAsync("https://api.github.com/users/yourusername/repos");
        var repos = JsonSerializer.Deserialize<List<GitHubRepo>>(response);
#pragma warning disable CS8604 // Possible null reference argument.
        LatestProjects = repos.Take(3).Select(repo => new ProjectViewModel
        {
            Name = repo.Name,
            Description = repo.Description,
            Url = repo.HtmlUrl
        }).ToList();
#pragma warning restore CS8604 // Possible null reference argument.
    }

    private class GitHubRepo
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string HtmlUrl { get; set; }
    }
}
