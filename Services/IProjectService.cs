// Services/IProjectService.cs
using MyApp.Models;

namespace MyApp.Services
{
    public interface IProjectService
    {
        Project? GetProjectById(int id);
    }
}