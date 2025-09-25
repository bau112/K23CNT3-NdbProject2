namespace WebsiteBanHang.Models
{
    public class Order
    {
        public string OrderId { get; set; } = Guid.NewGuid().ToString("N");
        public List<CartItem> Items { get; set; } = new();
        public string CustomerName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string PaymentMethod { get; set; } = "";
        public decimal Total => Items.Sum(i => i.Price * i.Quantity);
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
