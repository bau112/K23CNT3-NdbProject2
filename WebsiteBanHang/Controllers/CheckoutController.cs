using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Helpers;
using WebsiteBanHang.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebsiteBanHang.Controllers
{
    public class CheckoutController : Controller
    {
        private const string CART_KEY = "CART";

        public IActionResult Index()
        {
            // Lấy giỏ hàng từ session, nếu null thì tạo mới List<CartItem>
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult PlaceOrder(string name, string phone, string address, string payment)
        {
            // Lấy giỏ hàng
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();

            // Nếu giỏ hàng trống, quay lại trang Cart
            if (!cart.Any()) return RedirectToAction("Index", "Cart");

            // Tạo đơn hàng
            var order = new Order
            {
                Items = cart,
                CustomerName = name,
                Phone = phone,
                Address = address,
                PaymentMethod = payment
            };

            // Lưu đơn hàng tạm thời vào TempData
            TempData["LastOrder"] = System.Text.Json.JsonSerializer.Serialize(order);

            // Xóa giỏ hàng khỏi session
            HttpContext.Session.Remove(CART_KEY);

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            // Lấy dữ liệu đơn hàng từ TempData
            var lastOrderJson = TempData["LastOrder"] as string;

            // Nếu null hoặc rỗng, quay về trang Home
            if (string.IsNullOrEmpty(lastOrderJson))
                return RedirectToAction("Index", "Home");

            // Deserialize an toàn
            var order = System.Text.Json.JsonSerializer.Deserialize<Order>(lastOrderJson);

            return View(order);
        }
    }
}
