using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Narrativia.Data.Entities;
using Narrativia.DTO;
using Narrativia.DTO.BlogPost;
using Narrativia.Repository;
using Narrativia.Repository.Data;

namespace Narrativia.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IRepository<BlogPost> _blogPostRepository;

        public BlogPostService(IRepository<BlogPost> blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        public IEnumerable<BlogPostListDto> GetBlogPosts()
        {
            // TODO NOT THIS!
            var blogPosts = _blogPostRepository.GetAll().AsQueryable();
            return blogPosts.Select(bp => new BlogPostListDto(bp));
        }

        public BlogPostDto GetBlogPost(uint id)
        {
            var dbBlogPost = _blogPostRepository.Get(id);
            return new BlogPostDto(dbBlogPost);
        }

        public Task<bool> IncreaseViewCount(uint id)
        {
            var dbBlogPost = _blogPostRepository.Get(id);
            dbBlogPost.Views += 1;
            return UpdateBlogPost(dbBlogPost);
        }

        public void InsertBlogPost(BlogPost blogPost)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> UpdateBlogPost(BlogPost blogPost)
        {
            _blogPostRepository.Update(blogPost);
            return await _blogPostRepository.SaveChangesAsync() > 0;
        }

        public void DeleteBlogPost(uint id)
        {
            throw new System.NotImplementedException();
        }
    }
}