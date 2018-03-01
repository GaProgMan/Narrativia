using Narrativia.Data.Entities;

namespace Narrativia.DTO
{
    public class PageDto : BaseContentDto
    {
        public PageDto(Page dbPage)
        {
            Title = dbPage.Title;
            BodyText = dbPage.BodyText;
            DisplayName = dbPage.DisplayName;
            IconIdentifier = dbPage.IconIdentifier;
            HeaderImageUrl = dbPage.HeaderImageUrl;
        }
        
        public string DisplayName { get; set; }
        public string IconIdentifier { get; set; }
    }
}