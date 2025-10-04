using WebsiteBanHang.Models;

namespace WebsiteBanHang.Services
{
    public static class FakeData
    {
        public static List<Product> Products { get; set; } = new()
        {
            new Product { Id=1, Name="iPhone 15 Pro Max", Category="Phone", Price=25000000, NewPrice=21990000, Image="ip15prm.jpg", Description="iPhone 15 Pro Max (Chính hãng VN/A)" },
            new Product { Id=2, Name="Samsung S24 Ultra", Category="Phone", Price=22000000, NewPrice=18990000, Image="sss24u.jpg", Description="Samsung Galaxy S24 Ultra (Chính hãng)" },
            new Product { Id=3, Name="Google Pixel 9", Category="Phone", Price=16000000, NewPrice=14990000, Image="ggpx9.jpg", Description="Google Pixel 9 (Chính hãng)" },
            new Product { Id=4, Name="Samsung S25 Ultra", Category="Phone", Price=28000000, NewPrice=25990000, Image="sss25u.jpg", Description="Samsung Galaxy S25 Ultra(Chính hãng)" },
            new Product { Id=5, Name="iPhone 16 Pro Max", Category="Phone", Price=30000000, NewPrice=28990000, Image="ip16prm.jpg", Description="iPhone 16 Pro Max (Chính hãng VN/A)" },
            new Product { Id=6, Name="iPhone 17 Pro Max", Category="Phone", Price=32000000, NewPrice=30990000, Image="ip17prm.jpg", Description="iPhone 17 Pro Max (Chính hãng VN/A)" },
            new Product { Id=7, Name="Dell XPS 13", Category="Laptop", Price=25000000, NewPrice=23990000, Image="dellxps13.jpg", Description="Laptop Dell XPS 13 (Chính hãng)" },
            new Product { Id=8, Name="Tay cầm Dualsense Edge", Category="Accessory", Price=5000000, NewPrice=4399000, Image="ps5.jpg", Description="Tay cầm chơi game Dualsense Edge" },
            new Product { Id=9, Name="Tay cầm E-DRAEGP7603", Category="Accessory", Price=500000, NewPrice=390000, Image="taycam.jpg", Description="Tay cầm chơi game E-DRAEGP7603" },
            new Product { Id=10, Name="Tai nghe SamSung có dây IA500", Category="Accessory", Price=100000, NewPrice=90000, Image="tainghess.jpg", Description="Tai nghe chính hãng SamSung IA500" },
            new Product { Id=11, Name="Đồng hồ Casio MTP-1384D-7ADF", Category="Accessory", Price=5000000, NewPrice=4500000, Image="donghocasio.jpg", Description="Đồng hồ Nam Casio MTP-1384D-7ADF" },
            new Product { Id=12, Name="Đồng hồ Apple watch Ultra 2", Category="Accessory", Price=9000000, NewPrice=800000, Image="apwatchU2.jpg", Description="Đồng hồ Apple watch Ultra 2" },
            new Product { Id=13, Name="Đồng hồ Apple watch Series 4", Category="Accessory", Price=8500000, NewPrice=7400000, Image="apwatch.jpg", Description="Đồng hồ Apple watch Series 4" },
            new Product { Id=14, Name="Đồng hồ SamSung Galaxy Watch", Category="Accessory", Price=5000000, NewPrice=4000000, Image="sswatch.jpg", Description="Đồng hồ SamSung Galaxy Watch" },
            new Product { Id=15, Name="Đồng hồ SamSung Galaxy Watch 6", Category="Accessory", Price=5000000, NewPrice=4500000, Image="sswatch6.jpg", Description="Đồng hồ SamSung Galaxy Watch 6" },
            new Product { Id=16, Name="Đồng hồ Xiaomi Redmi Watch 4", Category="Accessory", Price=1500000, NewPrice=1000000, Image="donghoxiaomi.jpg", Description="Đồng hồ Xiaomi Redmi Watch 4" },
            new Product { Id=17, Name="Đồng hồ Huawei Watch D2", Category="Accessory", Price=2500000, NewPrice=1500000, Image="donghohuaweid2.jpg", Description="Đồng hồ Huawei Watch D2" },
            new Product { Id=18, Name="Đồng hồ Huawei Watch GT5", Category="Accessory", Price=3000000, NewPrice=2000000, Image="donghohuaweigt5.jpg", Description="Đồng hồ Huawei Watch GT5" },
            new Product { Id=19, Name="Đầu chuyển đổi Type-HDMI", Category="Accessory", Price=250000, NewPrice=200000, Image="dauchuyendoi.jpg", Description="Đầu chuyển đổi Type-C to HDMI,USP " },
            new Product { Id=20, Name="Tai nghe Air Pods Series", Category="Accessory", Price=2500000, NewPrice=1500000, Image="Air.jpg", Description="Tai nghe Air Pods Series" },
            new Product { Id=21, Name="Tai nghe Air Pods Pro 4", Category="Accessory", Price=3500000, NewPrice=2550000, Image="AirPro4.jpg", Description="Tai nghe Air Pods Pro 4" },
            new Product { Id=22, Name="Tai nghe Air Pods Ultra", Category="Accessory", Price=4500000, NewPrice=4000000, Image="AirUltra.jpg", Description="Tai nghe Air Pods Ultra" },
            new Product { Id=23, Name="Bàn phím cơ Cidoo", Category="Accessory", Price=1000000, NewPrice=900000, Image="banphimcidoo.jpg", Description="Bàn phím cơ Cidoo không dây" },
            new Product { Id=24, Name="Chuột không dây Green", Category="Accessory", Price=900000, NewPrice=700000, Image="chuotgreen.jpg", Description="Chuột không dây Green" },
            new Product { Id=25, Name="Chuột không dây Logitech", Category="Accessory", Price=700000, NewPrice=550000, Image="chuotlogitech.jpg", Description="Chuột không dây Logitech" },
            new Product { Id=26, Name="Dây sạc Type-C to Lightning", Category="Accessory", Price=150000, NewPrice=100000, Image="daysac.jpg", Description="Dây sạc Type-C to Lightning" },
            new Product { Id=27, Name="Màn hình máy tính Dell", Category="Accessory", Price=9000000, NewPrice=7500000, Image="manhinhdell.jpg", Description="MÀn hình máy tính Dell" },
            new Product { Id=28, Name="Sạc dự phòng AVA+", Category="Accessory", Price=900000, NewPrice=700000, Image="sacava.jpg", Description="Sạc dự phòng AVA+" },
            new Product { Id=29, Name="Sạc dự phòng Gutek", Category="Accessory", Price=500000, NewPrice=450000, Image="sacgutek.jpg", Description="Sạc dự phòng Gutek" },
            new Product { Id=30, Name="Sạc dự phòng Apple Chĩnh Hãng", Category="Accessory", Price=5000000, NewPrice=4500000, Image="sacip.jpg", Description="Sạc dự phòng Apple Chính Hãng" },
            new Product { Id=31, Name="Sạc dự phòng Ugreen", Category="Accessory", Price=900000, NewPrice=750000, Image="sacugreen.jpg", Description="Sạc dự phòng Ugreen" },
        };

        public static List<BlogPost> BlogPosts { get; set; } = new()
        {
            new BlogPost { Id=1, Title="Tin công nghệ 1", Content="Nội dung bài viết 1", Image="blog1.jpg", CreatedAt = DateTime.Now.AddDays(-2) },
            new BlogPost { Id=2, Title="Tin công nghệ 2", Content="Nội dung bài viết 2", Image="blog2.jpg", CreatedAt = DateTime.Now.AddDays(-1) },
            new BlogPost { Id=3, Title="Tin công nghệ 3", Content="Nội dung bài viết 3", Image="blog3.jpg", CreatedAt = DateTime.Now }
        };
    }
}
