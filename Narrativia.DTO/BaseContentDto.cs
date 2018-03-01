using System;

namespace Narrativia.DTO
{
    public abstract class BaseContentDto
    {
        public UInt64 Id { get; set; }
        public string Title { get; set; }
        public string HeaderImageUrl { get; set; }
        public string BodyText { get; set; }
    }
}