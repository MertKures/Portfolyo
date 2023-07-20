using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string p)
        {
            return View();
        }
    }
}
