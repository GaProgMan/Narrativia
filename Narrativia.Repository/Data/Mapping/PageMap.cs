using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Narrativia.Data.Entities;

namespace Narrativia.Repository.Data.Mapping
{
    public class PageMap
    {
        public PageMap(EntityTypeBuilder<Page> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(page => page.Id);
            
            entityTypeBuilder.Property(blog => blog.Title).IsRequired();
            entityTypeBuilder.Property(blog => blog.BodyText).IsRequired();
            
            entityTypeBuilder.ToTable("Pages");
        }
    }
}