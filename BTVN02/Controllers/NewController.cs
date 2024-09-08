using BTVN02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTVN02.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            return View(); // trả về view Profile.cshtml
        }

        public IActionResult MayTinh(int a = 0, int b = 0, string pheptinh = "cong")
            {
            string ketQua = "";

            switch (pheptinh.ToLower())
            {
                case "cong":
                    ketQua = $"{a} + {b} = {a + b}";
                    break;
                case "tru":
                    ketQua = $"{a} - {b} = {a - b}";
                    break;
                case "nhan":
                    ketQua = $"{a} * {b} = {a * b}";
                    break;
                case "chia":
                    if (b != 0)
                    {
                        ketQua = $"{a} / {b} = {(float)a / b}";
                    }
                    else
                    {
                        ketQua = "Không thể chia cho 0!";
                    }
                    break;
                default:
                    ketQua = "Phép toán không hợp lệ!";
                    break;
            }

            ViewBag.KetQua = ketQua;

            // Chuyển đến view MayTinh
            return View();
             }

        public IActionResult Profile()
        {
            return View();
        }
    }

    


}


