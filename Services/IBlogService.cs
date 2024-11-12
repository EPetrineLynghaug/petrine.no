using System.Collections.Generic;
using System.Threading.Tasks;
using petrine.no.ViewModels;

namespace petrine.no.Services
{
    public interface IBlogService
    {
        Task<BlogPostViewModel?> GetBlogPostByIdAsync(int id);
        Task<List<BlogPostViewModel>> GetAllBlogPostsAsync(); // Ny metode for å hente alle blogginnlegg
    }
}