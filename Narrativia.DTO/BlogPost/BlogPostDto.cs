namespace Narrativia.DTO.BlogPost
{
    public class BlogPostDto : BaseContentDto
    {
        public BlogPostDto(Data.Entities.BlogPost dbPost)
        {
            Title = dbPost.Title;
            Id = dbPost.Id;
            HeaderImageUrl = dbPost.HeaderImageUrl;
            BodyText = dbPost.BodyText;
        }
    }
}