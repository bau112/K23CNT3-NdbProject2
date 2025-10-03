using System.Collections.Generic;

namespace WebsiteBanHang.Models
{
    public class Order
    {
        public List<CartItem> Items { get; set; } = new();
        public string CustomerName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
