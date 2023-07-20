using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class SkillController : Controller
    {
        SkillManager _skillManager = new(new EfSkillDal());

        [HttpGet("/Skill/")]
        public IActionResult Index()
        {
            ViewBag.v1 = "Yetenek Listeleme Sayfası";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Listeleme";
            var values = _skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.v1 = "Yetenek Listeleme Sayfası";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenek Ekleme";
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            _skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            var skill = _skillManager.TGetById(id);
            _skillManager.TDelete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.v1 = "Yetenek Listeleme Sayfası";
            ViewBag.v2 = "Yetenekler";
            ViewBag.v3 = "Yetenekler Güncelleme";
            var skill = _skillManager.TGetById(id);
            return View(skill);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            _skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
    }
}
