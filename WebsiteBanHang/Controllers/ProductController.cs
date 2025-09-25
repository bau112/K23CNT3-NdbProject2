using Microsoft.AspNetCore.Mvc;

namespace WebsiteBanHang.Controllers
{
    public class ProductController : Controller
    {
        private static List<dynamic> products = new List<dynamic>
        {
            new {
                Id = 1,
                Name = "iPhone 15",
                OldPrice = "25.000.000đ",
                NewPrice = "21.990.000đ",
                Description = "iPhone 15 mới nhất với nhiều cải tiến vượt trội.",
                Image = "/images/ip15.jfif",
                Video = "https://www.youtube.com/watch?v=mRdYzyfZpzw",
                Category = "Phone"
            },
            new {
                Id = 2,
                Name = "Samsung Galaxy S25",
                OldPrice = "20.000.000đ",
                NewPrice = "17.990.000đ",
                Description = "Samsung Galaxy cao cấp, màn hình sắc nét.",
                Image = "/images/sss25.jfif",
                Video = "https://www.youtube.com/watch?v=TcK3gvgB1n8",
                Category = "Phone"
            },
            new {
                Id = 3,
                Name = "MacBook Pro",
                OldPrice = "45.000.000đ",
                NewPrice = "39.990.000đ",
                Description = "Laptop MacBook Pro hiệu năng mạnh mẽ.",
                Image = "/images/macbook.webp",
                Video = "https://www.youtube.com/watch?v=27R5tv0r2H4",
                Category = "Laptop"
            },
            new {
                Id = 4,
                Name = "Dell XPS",
                OldPrice = "35.000.000đ",
                NewPrice = "29.990.000đ",
                Description = "Dell XPS mỏng nhẹ, bền bỉ.",
                Image = "/images/dellxps.jpg",
                Video = "https://www.youtube.com/watch?v=I8CaRq1iNfM",
                Category = "Laptop"
            },
            new {
                Id = 5,
                Name = "Tai nghe Airpods Pro 2",
                OldPrice = "2.000.000đ",
                NewPrice = "1.490.000đ",
                Description = "Tai nghe Bluetooth âm thanh sống động.",
                Image = "/images/airpodspro.jpg",
                Video = "https://www.youtube.com/watch?v=N89QjcxhydI",
                Category = "Accessory"
            },
            new {
                Id = 6,
                Name = "Sạc dự phòng Bauseus",
                OldPrice = "1.200.000đ",
                NewPrice = "890.000đ",
                Description = "Pin sạc dự phòng dung lượng cao.",
                Image = "/images/baseus,png",
                Video = "https://www.youtube.com/watch?v=a4miGfnnvDs",
                Category = "Accessory"
            },
            new {
                Id = 7,
                Name = "Thay màn hình iPhone",
                OldPrice = "5.000.000đ",
                NewPrice = "3.500.000đ",
                Description = "Dịch vụ thay màn hình chính hãng cho iPhone.",
                Category = "Repair"
            },
            new {
                Id = 8,
                Name = "Thay pin Samsung",
                OldPrice = "1.500.000đ",
                NewPrice = "1.000.000đ",
                Description = "Dịch vụ thay pin Samsung uy tín.",
                Category = "Repair"
            }
        };

        public IActionResult Phone()
        {
            ViewBag.Products = products.Where(p => p.Category == "Phone").ToList();
            return View();
        }

        public IActionResult Laptop()
        {
            ViewBag.Products = products.Where(p => p.Category == "Laptop").ToList();
            return View();
        }

        public IActionResult Accessory()
        {
            ViewBag.Products = products.Where(p => p.Category == "Accessory").ToList();
            return View();
        }

        public IActionResult Repair()
        {
            ViewBag.Products = products.Where(p => p.Category == "Repair").ToList();
            return View();
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            ViewBag.Product = product;
            return View();
        }
    }
}
