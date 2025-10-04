using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Services;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Phone(string? sortOrder)
        {
            return Category("Phone", sortOrder);
        }

        public IActionResult Laptop(string? sortOrder)
        {
            return Category("Laptop", sortOrder);
        }

        public IActionResult Accessory(string? sortOrder)
        {
            return Category("Accessory", sortOrder);
        }

        private IActionResult Category(string category, string? sortOrder)
        {
            var products = FakeData.Products.Where(p => p.Category == category).ToList();

            sortOrder = sortOrder?.ToLower();
            products = sortOrder switch
            {
                "price_asc" => products.OrderBy(p => p.NewPrice).ToList(),
                "price_desc" => products.OrderByDescending(p => p.NewPrice).ToList(),
                _ => products
            };

            ViewBag.SortOrder = sortOrder;
            ViewBag.Category = category;

            return View("Category", products);
        }

        public IActionResult Details(int id, string? returnUrl)
        {
            var product = FakeData.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            ViewBag.ReturnUrl = returnUrl ?? Url.Action("Index", "Home");
            return View(product);
        }
    }
}
