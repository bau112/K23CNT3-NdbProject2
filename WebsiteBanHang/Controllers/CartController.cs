using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Helpers;
using WebsiteBanHang.Models;
using WebsiteBanHang.Services;

namespace WebsiteBanHang.Controllers
{
    public class CartController : Controller
    {
        private const string CART_KEY = "CART";

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            return View(cart);
        }

        [HttpPost]
        public IActionResult Add(int productId, int qty = 1, string color = "", string memory = "")
        {
            var p = FakeData.Products.FirstOrDefault(x => x.Id == productId);
            if (p == null) return NotFound();

            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            var item = cart.FirstOrDefault(x => x.ProductId == productId && x.Color == color && x.Memory == memory);
            if (item == null)
            {
                cart.Add(new CartItem
                {
                    ProductId = productId,
                    Name = p.Name,
                    Image = p.Image,
                    Price = p.NewPrice,
                    Quantity = qty,
                    Color = color,
                    Memory = memory
                });
            }
            else
            {
                item.Quantity += qty;
            }
            HttpContext.Session.SetObject(CART_KEY, cart);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(int productId, int qty, string color = "", string memory = "")
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            var item = cart.FirstOrDefault(x => x.ProductId == productId && x.Color == color && x.Memory == memory);
            if (item != null)
            {
                if (qty <= 0) cart.Remove(item);
                else item.Quantity = qty;
            }
            HttpContext.Session.SetObject(CART_KEY, cart);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int productId, string color = "", string memory = "")
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            var item = cart.FirstOrDefault(x => x.ProductId == productId && x.Color == color && x.Memory == memory);
            if (item != null) cart.Remove(item);
            HttpContext.Session.SetObject(CART_KEY, cart);
            return RedirectToAction("Index");
        }
    }
}
