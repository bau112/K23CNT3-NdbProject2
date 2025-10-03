using System;

namespace WebsiteBanHang.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Image { get; set; } = "blog-default.jpg";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
