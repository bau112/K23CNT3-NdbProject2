using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Services;

namespace WebsiteBanHang.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index() => View(FakeData.Products);

        public IActionResult Details(int id)
        {
            var p = FakeData.Products.FirstOrDefault(x => x.Id == id);
            if (p == null) return NotFound();
            return View(p);
        }

        public IActionResult Phone() => View("Index", FakeData.Products.Where(p => p.Category == "Phone").ToList());
        public IActionResult Laptop() => View("Index", FakeData.Products.Where(p => p.Category == "Laptop").ToList());
    }
}
