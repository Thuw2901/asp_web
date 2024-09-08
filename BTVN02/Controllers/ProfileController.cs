using Microsoft.AspNetCore.Mvc;

namespace BTVN02.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
