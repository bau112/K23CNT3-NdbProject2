namespace WebsiteBanHang.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Summary { get; set; } = "";
        public string Content { get; set; } = "";
        public string Image { get; set; } = "";
        public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
    }
}
