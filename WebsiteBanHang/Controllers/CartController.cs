using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Models;
using WebsiteBanHang.Services;
using WebsiteBanHang.Helpers;

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

        public IActionResult Add(int id)
        {
            var product = FakeData.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();

            var item = cart.FirstOrDefault(c => c.ProductId == id);
            if (item == null)
            {
                cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Image = product.Image,
                    Price = product.NewPrice,
                    Quantity = 1
                });
            }
            else
            {
                item.Quantity++;
            }

            HttpContext.Session.SetObject(CART_KEY, cart);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int id, int quantity)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            var item = cart.FirstOrDefault(c => c.ProductId == id);

            if (item != null)
            {
                if (quantity > 0)
                    item.Quantity = quantity;
                else
                    cart.Remove(item);

                HttpContext.Session.SetObject(CART_KEY, cart);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var cart = HttpContext.Session.GetObject<List<CartItem>>(CART_KEY) ?? new List<CartItem>();
            cart.RemoveAll(c => c.ProductId == id);
            HttpContext.Session.SetObject(CART_KEY, cart);
            return RedirectToAction("Index");
        }
    }
}
