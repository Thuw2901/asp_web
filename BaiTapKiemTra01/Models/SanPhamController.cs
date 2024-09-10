using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult BaiTap2()
        {
            var sanPham = new SanPhamViewModel
            {
                TenSP = "Bánh Mì",
                GiaBan = 15000,
                AnhMoTa = "~/image/BanhMi.jpg"
            };

            var sanpham = new SanPhamViewModel
            {
                TenSP = "Sữa",
                GiaBan = 12000,
                AnhMoTa = "~/image/Sua.jfif"
            };

            var SanPham = new SanPhamViewModel
            {
                TenSP = "Kẹo",
                GiaBan = 5000,
                AnhMoTa = "~/image/Keo.jfif"
            };

            return View(sanPham);
            
        }
    }
}
