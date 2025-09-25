using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Services;

namespace WebsiteBanHang.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var featured = FakeData.Products.Take(4).ToList();
            return View(featured); // Views/Home/Index.cshtml - bạn có thể reuse Index view or create one
        }
    }
}
