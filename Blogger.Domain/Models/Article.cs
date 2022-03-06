using System;

namespace Blogger.Domain.Models
{
    public class Article : Entity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string CoverImage { get; set; }
        public int? ManagerId { get; set; }
        public string ManagerName { get; set; }
        public DateTime CreationTime { get; set; }
        public int ReadCount { get; set; }
        public int LikeCount { get; set; }
    }
}
