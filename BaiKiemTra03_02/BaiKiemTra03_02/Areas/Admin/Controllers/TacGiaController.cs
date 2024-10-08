using Microsoft.AspNetCore.Mvc;
using BaiKiemTra03_02.Data;
using BaiKiemTra03_02.Models;

namespace BaiKiemTra03_02.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TacGiaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TacGiaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var tacgias = _db.TacGia.ToList();
            return View(tacgias);
        }

        [HttpGet]
        public IActionResult Upsert(int id)
        {
            TacGia tacgia = new TacGia();
            if (id == 0)
            {
                return View(tacgia);
            }
            else
            {
                tacgia = _db.TacGia.Find(id);
                return View(tacgia);
            }
        }

        [HttpPost]
        public IActionResult Upsert(TacGia tacgia)
        {
            if (ModelState.IsValid)
            {
                if (tacgia.Id == 0)
                {
                    _db.TacGia.Add(tacgia);
                }
                else
                {
                    _db.TacGia.Update(tacgia);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tacgia);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var tacgia = _db.TacGia.Find(id);

            if (tacgia == null)
            {
                return NotFound();
            }

            return View(tacgia);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var tacgia = _db.TacGia.Find(id);
            if (tacgia == null)
            {
                return Json(new { success = false, message = "Không tìm thấy tác giả!" });
            }
            _db.TacGia.Remove(tacgia);
            _db.SaveChanges();
            return Json(new { success = true, message = "Xóa thành công!" });
        }
    }
}
