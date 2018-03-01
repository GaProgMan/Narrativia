using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Narrativia.Services;

namespace Narrativia.Ui.Api
{
    [Route("/api/[controller]")]
    public class BlogPostController : BaseApiController
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpGet("{id}")]
        public JsonResult Get(uint id)
        {
            var blogPost = _blogPostService.GetBlogPost(id);
            return blogPost == null
                ? ErrorResponse()
                : SingleResult(blogPost);
        }

        [HttpGet("list")]
        public JsonResult List()
        {
            var blogPosts = _blogPostService.GetBlogPosts();
            return blogPosts == null
                ? ErrorResponse()
                : MultipleResults(blogPosts);
        }

        [HttpGet("view")]
        public async Task<JsonResult> View(uint id)
        {
            var response = await _blogPostService.IncreaseViewCount(id);
            return BoolResponse(response, string.Empty);
        }
    }
}