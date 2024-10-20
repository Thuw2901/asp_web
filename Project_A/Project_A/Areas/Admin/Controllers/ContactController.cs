using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Project_A.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ThankYou(string name, string email, string message)
        {
            // Gửi email hoặc xử lý thông tin ở đây

            return View(); // Chuyển hướng đến view ThankYou
        }
    }
}
