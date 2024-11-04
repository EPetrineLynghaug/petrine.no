// Services/ProjectService.cs
using MyApp.Models;

namespace MyApp.Services
{
    public class ProjectService : IProjectService
    {
        public Project? GetProjectById(int id)
        {
            // Replace with actual data access code; this is a stub
            return new Project
            {
                Id = id,
                Name = "Sample Project",
                Description = "This is a sample project description.",
                StartDate = DateTime.Now.AddMonths(-1),
                EndDate = null,
                Status = "Active"
            };
        }
    }
}