using Microsoft.AspNetCore.Mvc;

namespace WebsiteBanHang.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Repair()
        {
            ViewData["Title"] = "Dịch vụ sửa chữa";
            return View();
        }
    }
}
