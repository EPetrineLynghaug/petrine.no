using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using petrine.no.Services;
using petrine.no.ViewModels;

namespace petrine.no.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProjectService _projectService;
        private readonly IBlogService _blogService; // Legger til BlogService-avhengighet

        public List<ProjectViewModel> LatestProjects { get; set; } = new List<ProjectViewModel>();
        public List<BlogPostViewModel> LatestBlogPosts { get; set; } = new List<BlogPostViewModel>(); // Liste for blogginnlegg

        public IndexModel(IProjectService projectService, IBlogService blogService)
        {
            _projectService = projectService;
            _blogService = blogService;
        }

        public async Task OnGetAsync()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            LatestProjects = new List<ProjectViewModel>(projects);

            // Henter blogginnlegg
            var blogPosts = await _blogService.GetAllBlogPostsAsync();
            LatestBlogPosts = new List<BlogPostViewModel>(blogPosts);
        }
    }
}