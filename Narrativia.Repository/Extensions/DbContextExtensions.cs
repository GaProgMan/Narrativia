using System.Linq;
using System.Threading.Tasks;
using Narrativia.Repository.Data;
using Narrativia.Repository.Helpers;

namespace Narrativia.Repository.Extensions
{
    public static class DbContextExtensions
    {
        public static async Task<int> EnsureSeedData(this DataContext appContext)
        {
            Task<int> blogTask = null;
            Task<int> commentTask = null;

            var blogCount = default(int);
            var commentCount = default(int);

            var dbSeeder = new DatabaseSeeder(appContext);

            if (!appContext.BlogPosts.Any())
            {
                blogTask = dbSeeder.SeedBlogPosts();
            }

            if (!appContext.Comments.Any())
            {
                commentTask = dbSeeder.SeedComments();
            }

            if (blogTask != null)
            {
                blogCount = await blogTask;
            }

            if (commentTask != null)
            {
                commentCount = await commentTask;
            }

            return blogCount + commentCount;
        }
    }
}