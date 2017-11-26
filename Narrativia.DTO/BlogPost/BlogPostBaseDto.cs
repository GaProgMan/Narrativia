using System;

namespace Narrativia.DTO.BlogPost
{
    public class BlogPostBaseDto : BaseDto
    {
        public string Title { get; set; }
        public string HeaderImageUrl { get; set; }
        public UInt64 Id { get; set; }
    }
}