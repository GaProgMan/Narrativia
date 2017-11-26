namespace Narrativia.DTO.BlogPost
{
    public class BlogPostListDto : BlogPostBaseDto
    {
        public BlogPostListDto(Data.Entities.BlogPost dbPost)
        {
            Title = dbPost.Title;
            Id = dbPost.Id;
            HeaderImageUrl = dbPost.HeaderImageUrl;
            Excerpt = dbPost.Excerpt;
        }
        
        public string Excerpt { get; set; }
    }
}