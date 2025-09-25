using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Services;

namespace WebsiteBanHang.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeData.BlogPosts);
        }

        public IActionResult Details(int id)
        {
            var post = FakeData.BlogPosts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();
            return View(post);
        }
    }
}
