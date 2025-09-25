using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class AccountController : Controller
    {
        // very simple in-memory user store (demo only)
        private static List<UserModel> users = new List<UserModel>();

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                ViewBag.Error = "Tên đăng nhập hoặc mật khẩu không đúng";
                return View();
            }
            HttpContext.Session.SetString("User", user.Username);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(UserModel model)
        {
            if (users.Any(u => u.Username == model.Username))
            {
                ViewBag.Error = "Tài khoản đã tồn tại";
                return View();
            }
            users.Add(model);
            HttpContext.Session.SetString("User", model.Username);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");
            return RedirectToAction("Index", "Home");
        }
    }
}
