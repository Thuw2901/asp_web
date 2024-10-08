﻿using Project_A.Data;
using Project_A.Models;
using Microsoft.AspNetCore.Mvc;

namespace Project_A.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TheLoaiController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var theLoai = _db.TheLoai.ToList();
            ViewBag.TheLoai = theLoai;

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                //thêm thông tin vào bảng TheLoai
                _db.TheLoai.Add(theloai);
                //Lưu lại
                _db.SaveChanges();
                //Chuyển Trang về Index
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit( int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                //thêm thông tin vào bảng TheLoai
                _db.TheLoai.Update(theloai);
                //Lưu lại
                _db.SaveChanges();
                //Chuyển Trang về Index
                return RedirectToAction("Index");

            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.TheLoai.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.TheLoai.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }

        [HttpGet]
        public IActionResult Search(String searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                //Sử dugj LINQ để tìm kiếm
                var theloai = _db.TheLoai.Where(tl=>tl.Name.Contains(searchString)).ToList();

                ViewBag.SearchString = searchString;
                ViewBag.TheLoai = theloai;
            }
            else
            {
                var theloai =_db.TheLoai.ToList();

            }
            return View("Index");//SD lai view Index
        }
    }
}
