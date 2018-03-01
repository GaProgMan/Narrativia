using System.Collections.Generic;
using System.Threading.Tasks;
using Narrativia.Data.Entities;
using Narrativia.DTO;
using Narrativia.DTO.BlogPost;

namespace Narrativia.Services
{
    public interface IBlogPostService
    {
        IEnumerable<BlogPostListDto> GetBlogPosts();
        BlogPostDto GetBlogPost(uint id);
        Task<bool> IncreaseViewCount(uint id);
        void InsertBlogPost(BlogPost blogPost);
        Task<bool> UpdateBlogPost(BlogPost blogPost);
        void DeleteBlogPost(uint id);
    }
}