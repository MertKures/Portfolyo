using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "İstatistik Görüntüleme Sayfası";
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatistik Görüntüleme";
            return View();
        }
    }
}
