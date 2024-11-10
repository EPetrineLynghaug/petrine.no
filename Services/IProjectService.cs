using System.Collections.Generic;
using System.Threading.Tasks;
using petrine.no.ViewModels;

namespace petrine.no.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectViewModel>> GetAllProjectsAsync();
        ProjectViewModel? GetProjectByName(string name);
        ProjectViewModel? GetProjectById(int id);
    }
}