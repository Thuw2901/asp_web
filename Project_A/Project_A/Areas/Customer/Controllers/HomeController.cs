﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_A.Data;
using Project_A.Models;
using System.Diagnostics;

namespace Project_A.Areas.Customer.Controllers
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

        public IActionResult Index()
        {
            IEnumerable<SanPham> sanpham = _db.SanPham.Include("TheLoai").ToList();
            return View(sanpham);
        }

        public IActionResult LienHe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            SanPham sanpham = new SanPham();
            sanpham = _db.SanPham.Include(sp=>sp.TheLoai).FirstOrDefault(sp => sp.Id == id);

            return View(sanpham);

        }//sau đó sang trang index.cshtml của customer
        //quay lại add view và lấy code từ thầy

        [HttpGet]
        public IActionResult FilterByTheLoai(int id)
        {
            IEnumerable<SanPham> sanpham = _db.SanPham.Include("TheLoai")
                                                      .Where(sp=>sp.TheLoai.Id==id)
                                                      .ToList();
            return View("Index",sanpham);
        }
    }
}
