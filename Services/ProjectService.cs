using petrine.no.ViewModels; // Ensure this namespace is correct
using System;
using System.Collections.Generic;
using System.Linq;

namespace petrine.no.Services
{
    public class ProjectService : IProjectService
    {
        public IEnumerable<ProjectViewModel> GetAllProjects()
        {
            return new List<ProjectViewModel>
            {
                new ProjectViewModel
                {
                    Name = "RettVest",
                    Description = "This is a project about RettVest.",
                    Url = "https://github.com/EPetrineLynghaug/RettVest",
                    CreatedAt = DateTime.Now.AddMonths(-1),
                    ProjectCardImageUrl = "/assets/img/RettVest(hero).png" // Ensure this path is correct
                },
                new ProjectViewModel
                {
                    Name = "Community-Science-Museum",
                    Description = "An interactive exhibit showcasing the wonders of science and community.",
                    Url = "https://github.com/EPetrineLynghaug/Community-Science-Museum",
                    CreatedAt = DateTime.Now,
                    ProjectCardImageUrl = "/assets/img/community-science-museum.png" // Ensure this path is correct
                }
                // Add more projects as needed
            };
        }

        public ProjectViewModel? GetProjectByName(string name)
        {
            return GetAllProjects().FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public ProjectViewModel? GetProjectById(int id)
        {
            // Placeholder implementation; adjust as needed for actual ID fetching logic
            return GetAllProjects().FirstOrDefault(p => p.Name.GetHashCode() == id);
        }
    }
}