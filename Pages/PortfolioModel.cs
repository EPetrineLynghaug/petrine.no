using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using petrine.no.ViewModels;
using petrine.no.Services;
using System.Threading.Tasks;

namespace petrine.no.Pages
{
    public class PortfolioModel : PageModel
    {
        private readonly IProjectService _projectService;
        public List<ProjectViewModel> Projects { get; set; } = new List<ProjectViewModel>();

        public PortfolioModel(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public async Task OnGetAsync()
        {
            var projects = await _projectService.GetAllProjectsAsync();
            Projects = projects.ToList();
        }
    }
}