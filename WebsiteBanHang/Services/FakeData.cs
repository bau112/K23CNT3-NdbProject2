using WebsiteBanHang.Models;

namespace WebsiteBanHang.Services
{
    public static class FakeData
    {
        public static List<Product> Products = new List<Product>
        {
            new Product {
                Id=1, Name="iPhone 15", Image="iphone15.jpg", Category="Phone",
                OldPrice=25000000m, NewPrice=21990000m,
                Description="iPhone 15 — chip A17, camera 48MP.",
                VideoUrl="https://www.youtube.com/embed/xqyUdNxWazA",
                Colors=new List<string>{"Đen","Trắng","Hồng"},
                Memories=new List<string>{"128GB","256GB","512GB"}
            },
            new Product {
                Id=2, Name="Samsung Galaxy S23", Image="samsung-galaxy.jpg", Category="Phone",
                OldPrice=20000000m, NewPrice=17990000m,
                Description="Samsung Galaxy S23 — màn hình Dynamic AMOLED.",
                VideoUrl="https://www.youtube.com/embed/u9yv3RmqAm8",
                Colors=new List<string>{"Xám","Xanh"},
                Memories=new List<string>{"128GB","256GB"}
            },
            new Product {
                Id=3, Name="MacBook Pro M2", Image="macbook-pro.jpg", Category="Laptop",
                OldPrice=40000000m, NewPrice=36990000m,
                Description="MacBook Pro M2 — hiệu năng tốt cho sáng tạo.",
                VideoUrl="https://www.youtube.com/embed/t4ejFV6n4b8",
                Colors=new List<string>{"Bạc","Xám"},
                Memories=new List<string>{"512GB","1TB"}
            },
            new Product {
                Id=4, Name="AirPods Pro 2", Image="airpods.jpg", Category="Accessory",
                OldPrice=6500000m, NewPrice=6000000m,
                Description="AirPods Pro 2 — chống ồn chủ động.",
                VideoUrl="https://www.youtube.com/embed/lTTajzrSkCw",
                Colors=new List<string>{"Trắng"},
                Memories=new List<string>()
            },
            new Product {
                Id=101, Name="Thay màn hình iPhone", Image="repair-iphone.jpg", Category="Repair",
                OldPrice=5000000m, NewPrice=3500000m,
                Description="Thay màn hình chính hãng, bảo hành 6 tháng.",
                VideoUrl="",
                Colors=new List<string>(),
                Memories=new List<string>()
            }
        };

        public static List<BlogPost> BlogPosts = new List<BlogPost>
        {
            new BlogPost {
                Id=1, Title="Cách chọn điện thoại 2025",
                Summary="Hướng dẫn chọn điện thoại phù hợp...",
                Image="blog1.jpg", Content="Nội dung chi tiết...",
                PublishedAt=DateTime.UtcNow.AddDays(-7)
            },
            new BlogPost {
                Id=2, Title="So sánh iPhone vs Android",
                Summary="So sánh điểm mạnh...",
                Image="blog2.jpg", Content="Nội dung chi tiết...",
                PublishedAt=DateTime.UtcNow.AddDays(-3)
            }
        };
    }
}
