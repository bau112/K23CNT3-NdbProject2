using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Services;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string? sortOrder)
        {
            var allProducts = FakeData.Products ?? new List<Product>();

            sortOrder = sortOrder?.ToLower();
            allProducts = sortOrder switch
            {
                "price_asc" => allProducts.OrderBy(p => p.NewPrice).ToList(),
                "price_desc" => allProducts.OrderByDescending(p => p.NewPrice).ToList(),
                _ => allProducts
            };

            ViewBag.SortOrder = sortOrder;
            return View(allProducts);
        }
    }
}
