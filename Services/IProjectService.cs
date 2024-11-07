// Services/IProjectService.cs
using petrine.no.ViewModels; // Use the correct namespace for your ViewModel

namespace petrine.no.Services
{
    public interface IProjectService
    {
        ProjectViewModel? GetProjectById(int id); // Change to return ProjectViewModel
        IEnumerable<ProjectViewModel> GetAllProjects(); // Add this method
    }
}