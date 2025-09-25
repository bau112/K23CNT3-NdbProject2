using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Send(string name, string email, string message)
        {
            // TODO: forward email or save to DB. For demo we show a success page.
            TempData["ContactMsg"] = "Cảm ơn " + name + ". Chúng tôi đã nhận được tin nhắn.";
            return RedirectToAction("Index");
        }
    }
}
