using System.Collections.Generic;
using Narrativia.Data.Entities;
using Narrativia.DTO;
using Narrativia.DTO.BlogPost;

namespace Narrativia.Services
{
    public interface IBlogPostService
    {
        IEnumerable<BlogPostListDto> GetBlogPosts();
        BlogPostDto GetBlogPost(uint id);
        void InsertBlogPost(BlogPost blogPost);
        void UpdateBlogPost(BlogPost blogPost);
        void DeleteBlogPost(uint id);
    }
}