using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Narrativia.Data.Entities;

namespace Narrativia.Data.Mapping
{
    public class CommentMap
    {
        public CommentMap(EntityTypeBuilder<Comment> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(comment => comment.Id);

            entityTypeBuilder.Property(comment => comment.Username).IsRequired();
            entityTypeBuilder.Property(comment => comment.CommentText).IsRequired();

            entityTypeBuilder.ToTable("Comments");
        }
    }
}