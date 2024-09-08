using Microsoft.AspNetCore.Mvc;

namespace BTVN02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Đặng Thị Minh Thư";
            ViewBag.MSSV = " MSSV 1822041768";
            ViewBag.Nam = "Năm 2024";
            return View();
        }
    }
}
