using Narrativia.Data.Entities;

namespace Narrativia.DTO
{
    public class PageDto : BaseDto
    {
        public PageDto(Page dbPage)
        {
            Title = dbPage.Title;
            BodyText = dbPage.BodyText;
        }
        
        public string Title { get; set; }
        public string BodyText { get; set; }
    }
}