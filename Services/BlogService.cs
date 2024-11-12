using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using petrine.no.ViewModels;

namespace petrine.no.Services
{
    public class BlogService : IBlogService
    {
        private readonly List<BlogPostViewModel> _blogPosts = new List<BlogPostViewModel>
        {
            new BlogPostViewModel
            {
                Id = 1,
                Title = "Understanding the Basics of UX Design",
                Summary = "A quick overview of essential UX principles.",
                Author = "Petrine Lynghaug",
                PublishedDate = new DateTime(2023, 3, 15),
                ImageUrl = "/assets/img/RettVest(hero).png"
            }
            // Legg til flere bloggposter hvis ønskelig
        };

        public Task<BlogPostViewModel?> GetBlogPostByIdAsync(int id)
        {
            var blogPost = _blogPosts.FirstOrDefault(bp => bp.Id == id);
            return Task.FromResult(blogPost);
        }

        public Task<List<BlogPostViewModel>> GetAllBlogPostsAsync()
        {
            return Task.FromResult(_blogPosts);
        }
    }
}