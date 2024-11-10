using petrine.no.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace petrine.no.Services
{
    public class ProjectService : IProjectService
    {
        public async Task<IEnumerable<ProjectViewModel>> GetAllProjectsAsync()
        {
            return await Task.FromResult(new List<ProjectViewModel>
            {
                new ProjectViewModel
                {
                    Name = "RettVest",
                    Description = "This is a project about RettVest.",
                    CreatedAt = DateTime.Now.AddMonths(-1),
                    Url = "/RettVest"
                },
                new ProjectViewModel
                {
                    Name = "Community-Science-Museum",
                    Description = "An interactive exhibit showcasing the wonders of science and community.",
                    CreatedAt = DateTime.Now,
                    Url = "/CommunityScienceMuseum"
                }
            });
        }

        public ProjectViewModel? GetProjectByName(string name)
        {
            return GetAllProjectsAsync().Result.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public ProjectViewModel? GetProjectById(int id)
        {
            return GetAllProjectsAsync().Result.FirstOrDefault(p => p.Name.GetHashCode() == id);
        }
    }
}