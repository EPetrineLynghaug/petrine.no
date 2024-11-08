using petrine.no.ViewModels; // Ensure this namespace is correct
using System.Collections.Generic;

namespace petrine.no.Services
{
    public interface IProjectService
    {
        ProjectViewModel? GetProjectById(int id);
        ProjectViewModel? GetProjectByName(string name); // Ensure this method is declared
        IEnumerable<ProjectViewModel> GetAllProjects();
    }
}