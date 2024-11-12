using Microsoft.AspNetCore.Mvc.RazorPages;
using petrine.no.Services;
using petrine.no.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace petrine.no.Pages
{
    public class BlogListModel : PageModel
    {
        private readonly IBlogService _blogService;

        public List<BlogPostViewModel> BlogPosts { get; set; } = new();

        public BlogListModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task OnGetAsync()
        {
            BlogPosts = await _blogService.GetAllBlogPostsAsync();
        }
    }
}