namespace Narrativia.DTO.BlogPost
{
    public class BlogPostDto : BlogPostBaseDto
    {
        public BlogPostDto(Data.Entities.BlogPost dbPost)
        {
            Title = dbPost.Title;
            Id = dbPost.Id;
            HeaderImageUrl = dbPost.HeaderImageUrl;
            BodyText = dbPost.BodyText;
        }
        
        public string BodyText { get; set; }
    }
}