using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiKiemTra03_02.Data;
using BaiKiemTra03_02.Models;

namespace BaiKiemTra03_02.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SachController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SachController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var sach = _db.Sach.Include("TacGia").Include("TheLoai").ToList();
            return View(sach);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var sach = _db.Sach
                .Include(s => s.TacGia)
                .Include(s => s.TheLoai)
                .FirstOrDefault(s => s.Id == id);

            if (sach == null)
            {
                return NotFound();
            }

            return View(sach);
        }



        [HttpGet]
        public IActionResult Upsert(int id)
        {
            Sach sach = new Sach();
            IEnumerable<SelectListItem> dsTacGia = _db.TacGia.Select(tg => new SelectListItem
            {
                Value = tg.Id.ToString(),
                Text = tg.TenTacGia
            });

            IEnumerable<SelectListItem> dsTheLoai = _db.TheLoai.Select(tl => new SelectListItem
            {
                Value = tl.Id.ToString(),
                Text = tl.TenTheLoai
            });

            ViewBag.DSTacGia = dsTacGia;
            ViewBag.DSTheLoai = dsTheLoai;

            if (id == 0)
            {
                return View(sach);
            }
            else
            {
                sach = _db.Sach.Include("TacGia").Include("TheLoai").FirstOrDefault(s => s.Id == id);
                return View(sach);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Sach sach)
        {
            if (ModelState.IsValid)
            {
                if (sach.Id == 0)
                {
                    _db.Sach.Add(sach);
                }
                else
                {
                    _db.Sach.Update(sach);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sach);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var sach = _db.Sach.Find(id);
            if (sach == null)
            {
                return Json(new { success = false, message = "Không tìm thấy sách!" });
            }
            _db.Sach.Remove(sach);
            _db.SaveChanges();
            return Json(new { success = true, message = "Xóa thành công!" });
        }
    }
}
