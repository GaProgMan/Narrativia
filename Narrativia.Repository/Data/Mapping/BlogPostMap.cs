using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Narrativia.Data.Entities;

namespace Narrativia.Repository.Data.Mapping
{
    public class BlogPostMap
    {
        public BlogPostMap(EntityTypeBuilder<BlogPost> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(blog => blog.Id);
            
            entityTypeBuilder.Property(blog => blog.Title).IsRequired();
            entityTypeBuilder.Property(blog => blog.BodyText).IsRequired();
            entityTypeBuilder.Property(blog => blog.Excerpt).IsRequired();

            entityTypeBuilder.HasMany(blog => blog.Comments)
                .WithOne(comment => comment.BlogPost)
                .HasForeignKey(blog => blog.BlogPostId);


            entityTypeBuilder.ToTable("BlogPosts");
        }
    }
}