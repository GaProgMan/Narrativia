using System;
using System.Collections.Generic;

namespace Narrativia.Data.Entities
{
    public class BlogPost : ContentPage
    {
        public string Excerpt { get; set; }   
        public UInt32 Views { get; set; }
        public UInt32 Likes { get; set; }
        
        public virtual ICollection<Comment> Comments { get; set; }
    }
}