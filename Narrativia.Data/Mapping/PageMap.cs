using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Narrativia.Data.Entities;

namespace Narrativia.Data.Mapping
{
    public class PageMap
    {
        public PageMap(EntityTypeBuilder<Page> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(page => page.Id);
            
            entityTypeBuilder.Property(page => page.Title).IsRequired();
            entityTypeBuilder.Property(page => page.BodyText).IsRequired();
            entityTypeBuilder.Property(page => page.DisplayName).IsRequired();
            
            entityTypeBuilder.ToTable("Pages");
        }
    }
}