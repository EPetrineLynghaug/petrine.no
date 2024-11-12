using Microsoft.AspNetCore.Mvc.RazorPages;
using petrine.no.Services;
using petrine.no.ViewModels;
using System.Threading.Tasks;

namespace petrine.no.Pages
{
    public class BlogModel : PageModel
    {
        private readonly IBlogService _blogService;

        public BlogPostViewModel? BlogPost { get; set; }

        public BlogModel(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task OnGetAsync(int id)
        {
            BlogPost = await _blogService.GetBlogPostByIdAsync(id);
        }
    }
}