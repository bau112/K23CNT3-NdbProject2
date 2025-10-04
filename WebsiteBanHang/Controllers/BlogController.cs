using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Services;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var posts = (FakeData.BlogPosts ?? new List<BlogPost>())
                        .OrderByDescending(p => p.CreatedAt)
                        .ToList();

            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post = FakeData.BlogPosts.FirstOrDefault(p => p.Id == id);
            if (post == null) return NotFound();
            return View(post!);
        }
    }
}
