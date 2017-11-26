using System;

namespace Narrativia.Data.Entities
{
    public abstract class BaseAuditClass
    {
        public UInt64 Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}