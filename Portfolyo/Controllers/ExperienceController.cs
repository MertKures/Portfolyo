using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceManager _experienceManager = new(new EfExperienceDal());

        [HttpGet("/Experience/")]
        public IActionResult Index()
        {
            ViewBag.v1 = "Deneyimler Sayfası";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Listesi";
            var experiences = _experienceManager.TGetList();
            return View(experiences);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            ViewBag.v1 = "Deneyimler Sayfası";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            _experienceManager.TAdd(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            var experience = _experienceManager.TGetById(id);
            if (experience == null)
                // TODO: Redirect to error page
                return RedirectToAction("Index");
            _experienceManager.TDelete(experience);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            ViewBag.v1 = "Deneyimler Sayfası";
            ViewBag.v2 = "Deneyimler";
            ViewBag.v3 = "Deneyim Güncelleme";
            var result = _experienceManager.TGetById(id);
            if (result == null)
                // TODO: Redirect to error page
                return RedirectToAction("Index");
            return View(result);
        }

        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            var result = _experienceManager.TGetById(experience.ExperienceID);
            if (result == null)
                // TODO: Redirect to error page
                return RedirectToAction("Index");
            _experienceManager.TUpdate(experience);
            return RedirectToAction("Index");
        }
    }
}
