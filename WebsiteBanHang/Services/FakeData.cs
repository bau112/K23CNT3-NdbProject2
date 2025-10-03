using WebsiteBanHang.Models;

namespace WebsiteBanHang.Services
{
    public static class FakeData
    {
        public static List<Product> Products = new()
        {
            new Product { Id=1, Name="iPhone 15 Pro Max", Category="Phone", Price=25000000, NewPrice=21990000, Image="ip15prm.jpg", Description="iPhone 15 Pro Max chính hãng VN/A" },
            new Product { Id=2, Name="Samsung S24 Ultra", Category="Phone", Price=22000000, NewPrice=18990000, Image="sss24u.jpg", Description="Samsung Galaxy S24 Ultra" },
            new Product { Id=3, Name="Google Pixel", Category="Phone", Price=16000000, NewPrice=14990000, Image="ggpx9.jpg", Description="Google Pixel 9" },
            new Product { Id=2, Name="Samsung S25 Ultra", Category="Phone", Price=22000000, NewPrice=18990000, Image="sss25u.jpg", Description="Samsung Galaxy S25 Ultra" },
            new Product { Id=1, Name="iPhone 16 Pro Max", Category="Phone", Price=25000000, NewPrice=21990000, Image="ip16prm.jpg", Description="iPhone 16 Pro Max chính hãng VN/A" },
            new Product { Id=1, Name="iPhone 17 Pro Max", Category="Phone", Price=25000000, NewPrice=21990000, Image="ip17prm.jpg", Description="iPhone 17 Pro Max chính hãng VN/A" },
            new Product { Id=4, Name="Dell XPS 13", Category="Laptop", Price=25000000, NewPrice=23990000, Image="dellxps.jpg", Description="Laptop Dell XPS 13" }
        };

        public static List<BlogPost> BlogPosts = new()
        {
            new BlogPost { Id=1, Title="Tin công nghệ 1", Content="Nội dung bài viết 1", Image="blog1.jpg" },
            new BlogPost { Id=2, Title="Tin công nghệ 2", Content="Nội dung bài viết 2", Image="blog2.jpg" }
        };
    }
}
