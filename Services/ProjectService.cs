// Services/ProjectService.cs
using petrine.no.ViewModels; // Ensure this is correct
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
                    Url = "https://example.com/rettvest",
                    CreatedAt = DateTime.Now.AddMonths(-1),
                    ProjectCardImageUrl = "/assets/img/RettVest(hero).png"
                },
                // add more projects here
            };
        }

        public ProjectViewModel? GetProjectById(int id)
        {
            return GetAllProjects().FirstOrDefault(p => p.Name == "RettVest"); // Example logic for fetching a project by ID
        }
    }
}