using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager _featureManager = new(new EfFeatureDal());

        [HttpGet("/Feature/")]
        public IActionResult Index()
        {
            ViewBag.v1 = "Öne Çıkanlar Düzenleme Sayfası";
            ViewBag.v2 = "Öne Çıkanlar";
            ViewBag.v3 = "Öne Çıkanlar Düzenleme";
            var result = _featureManager.TGetById(1);
            return View(result);
        }

        [HttpPost("/Feature/")]
        public IActionResult Index(Feature feature)
        {
            _featureManager.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
