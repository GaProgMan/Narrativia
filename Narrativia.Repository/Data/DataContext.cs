using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Narrativia.Data.Entities;
using Narrativia.Data.Mapping;
using Narrativia.Repository.Extensions;

namespace Narrativia.Repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new BlogPostMap(modelBuilder.Entity<BlogPost>());
            new CommentMap(modelBuilder.Entity<Comment>());
            new PageMap(modelBuilder.Entity<Page>());
            
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            ChangeTracker.ApplyAuditInformation();
            
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}