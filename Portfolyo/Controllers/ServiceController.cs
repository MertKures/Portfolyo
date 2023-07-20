using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new(new EfServiceDal());

        [HttpGet("Service")]
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmet Listeleme Sayfası";
            ViewBag.v2 = "Hizmetler";
            ViewBag.v3 = "Hizmet Listesi";
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index", "Default");
        }

        [HttpGet]
        public IActionResult DeleteService(int id)
        {
            var service = serviceManager.TGetById(id);
            serviceManager.TDelete(service);
            return RedirectToAction("Index", "Default");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var service = serviceManager.TGetById(id);
            return View(service);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index", "Default");
        }
    }
}
