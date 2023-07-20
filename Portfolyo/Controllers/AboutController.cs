using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new(new EfAboutDal());

        [HttpGet("About")]
        public IActionResult Index()
        {
            ViewBag.v1 = "Hakkımda Düzenleme Sayfası";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Düzenleme";
            var values = aboutManager.TGetById(1);
            return View(values);
        }

        [HttpPost("About")]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
