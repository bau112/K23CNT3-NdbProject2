namespace WebsiteBanHang.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = "";
        public string Image { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public string Color { get; set; } = "";
        public string Memory { get; set; } = "";
    }
}
