using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Narrativia.Data.Entities
{
    public class Comment : BaseAuditClass
    {
        public Comment()
        {
            Replies = new Collection<Comment>();
        }
        
        public string Username { get; set; }
        public string CommentText { get; set; }
        public UInt64 BlogPostId { get; set; }
        
        public virtual ICollection<Comment> Replies { get; set; }
        public virtual BlogPost BlogPost { get; set; }
    }
}