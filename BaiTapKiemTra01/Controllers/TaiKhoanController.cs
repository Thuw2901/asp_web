using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            var taikhoan = new TaiKhoanViewModel
            {
                TenTaiKhoan = "Minnz",
                HoTen = "Nguyễn Đặng Thị Minh Thư",
                MatKhau = "2901",
                Tuoi = 20
            };

            return View(taikhoan);
        }

        // Phương thức POST: xử lý dữ liệu khi form được submit
        [HttpPost]
        public IActionResult Index(TaiKhoanViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Chuyển hướng tới trang thông tin tài khoản hoặc xử lý dữ liệu
                return RedirectToAction("ThongTinTaiKhoan");
            }

            // Nếu Model không hợp lệ, trả lại View để sửa lỗi
            return View(model);
        }

        // Phương thức GET cho DangKy
        public IActionResult DangKy()
        {
            return View();
        }

        // Phương thức POST cho DangKy
        [HttpPost]
        public IActionResult DangKy(TaiKhoanViewModel model)
        {
            if (ModelState.IsValid && !string.IsNullOrEmpty(model.TenTaiKhoan))
            {
                // Hiển thị giá trị của TenTaiKhoan trong form bằng Content()
                return Content($"Tên tài khoản đã nhập: {model.TenTaiKhoan}");
            }

            return View(model);
        }
    }
}
