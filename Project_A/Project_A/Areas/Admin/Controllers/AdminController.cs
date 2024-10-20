using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project_A.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        
        [AllowAnonymous]
        public IActionResult GioiThieu()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult TinTuc()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult ChinhSach()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult RiengTu()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult TinTuc1()
        {
            return View();
        }
    }
}
