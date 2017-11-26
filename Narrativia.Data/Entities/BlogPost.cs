using System;
using System.Collections.Generic;

namespace Narrativia.Data.Entities
{
    public class BlogPost : BaseAuditClass
    {
        public string Title { get; set; }
        public string HeaderImageUrl { get; set; }
        public string Excerpt { get; set; }
        public string BodyText { get; set; }
        
        public UInt32 Views { get; set; }
        public UInt32 Likes { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
    }
}