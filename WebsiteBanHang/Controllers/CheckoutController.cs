using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Helpers;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class CheckoutController : Controller
    {
        private const string CART_KEY = "CART";

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult PlaceOrder(string name, string phone, string address, string payment)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            if (!cart.Any()) return RedirectToAction("Index", "Cart");

            var order = new Order
            {
                Items = cart,
                CustomerName = name,
                Phone = phone,
                Address = address,
                PaymentMethod = payment
            };

            // TODO: save order to DB. For demo, keep in TempData (serialize)
            TempData["LastOrder"] = System.Text.Json.JsonSerializer.Serialize(order);

            // clear cart
            HttpContext.Session.Remove(CART_KEY);

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            if (TempData["LastOrder"] == null) return RedirectToAction("Index", "Home");
            var order = System.Text.Json.JsonSerializer.Deserialize<Order>(TempData["LastOrder"].ToString()!);
            return View(order);
        }
    }
}
