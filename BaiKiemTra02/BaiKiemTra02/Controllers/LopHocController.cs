
using BaikiemTra02.Models;
using BaiKiemTra02.Data;
using Microsoft.AspNetCore.Mvc;

namespace BaikiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LopHocController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Hiển thị danh sách
        public IActionResult Index()
        {
            var lopHoc = _db.LopHoc.ToList();
            ViewBag.LopHoc = lopHoc;
            return View();
        }

        // Thêm mới - GET
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Thêm mới - POST
        [HttpPost]
        public IActionResult Create(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                _db.LopHoc.Add(lophoc);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // Sửa - GET
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lopHoc = _db.LopHoc.Find(id);
            return View(lopHoc);
        }

        // Sửa - POST
        [HttpPost]
        public IActionResult Edit(LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                _db.LopHoc.Update(lophoc);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // Xóa - GET
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lopHoc = _db.LopHoc.Find(id);
            return View(lopHoc);
        }

        // Xóa - POST
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var lopHoc = _db.LopHoc.Find(id);
            if (lopHoc == null)
            {
                return NotFound();
            }
            _db.LopHoc.Remove(lopHoc);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Xem chi tiết
        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var lopHoc = _db.LopHoc.Find(id);
            return View(lopHoc);
        }
    }
}
