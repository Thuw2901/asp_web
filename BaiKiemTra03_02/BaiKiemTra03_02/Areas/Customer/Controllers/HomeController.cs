using BaiKiemTra03_02.Data;
using BaiKiemTra03_02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BaiKiemTra03_02.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        // Hiển thị danh sách sách
        public IActionResult Index()
        {
            // Lấy danh sách sách và bao gồm cả thông tin thể loại và tác giả
            IEnumerable<Sach> sach = _db.Sach.Include("TheLoai").Include("TacGia").ToList();
            return View(sach);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
