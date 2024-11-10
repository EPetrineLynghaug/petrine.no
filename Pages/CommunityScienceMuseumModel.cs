using Microsoft.AspNetCore.Mvc.RazorPages;
using petrine.no.Services;
using petrine.no.ViewModels;

namespace petrine.no.Pages
{
    public class CommunityScienceMuseumModel : PageModel
    {
        private readonly IProjectService _projectService;

        public ProjectViewModel? Project { get; private set; }

        public CommunityScienceMuseumModel(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public void OnGet()
        {
            Project = _projectService.GetProjectByName("Community-Science-Museum");
        }
    }
}