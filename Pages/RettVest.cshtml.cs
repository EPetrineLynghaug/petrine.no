using Microsoft.AspNetCore.Mvc.RazorPages;
using petrine.no.Services;
using petrine.no.ViewModels;

namespace petrine.no.Pages
{
    public class RettVestModel : PageModel
    {
        private readonly IProjectService _projectService;
        public ProjectViewModel? Project { get; private set; }

        public RettVestModel(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public void OnGet()
        {
            Project = _projectService.GetProjectByName("RettVest");

            if (Project == null)
            {
                // Handle the case where the project is not found
                Console.WriteLine("Project not found!");
            }
        }
    }
}