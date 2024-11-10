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
        public List<ProjectViewModel> LatestProjects { get; set; } = new List<ProjectViewModel>();

        public IndexModel(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task OnGetAsync()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            LatestProjects = new List<ProjectViewModel>(projects);
        }
    }
}