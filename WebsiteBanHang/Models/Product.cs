namespace WebsiteBanHang.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Image { get; set; } = "";
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string Description { get; set; } = "";
        public string VideoUrl { get; set; } = "";
        public List<string> Colors { get; set; } = new();
        public List<string> Memories { get; set; } = new();
        public string Category { get; set; } = ""; // Phone, Laptop, Accessory, Repair
    }
}
