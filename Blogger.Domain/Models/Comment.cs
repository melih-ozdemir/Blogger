using System;

namespace Blogger.Domain.Models
{
    public class Comment : Entity
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsApproved { get; set; }
    }
}
