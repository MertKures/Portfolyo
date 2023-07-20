using BusinessLayer.Concrete;
using BusinessLayer.Validation_Rules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new(new EfPortfolioDal());

        [HttpGet("/Portfolio/")]
        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Listeleme Sayfası";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Listesi";
            var values = portfolioManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewBag.v1 = "Proje Listeleme Sayfası";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Eklemek";
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            PortfolioValidator portfolioValidator = new();
            var result = portfolioValidator.Validate(p);

            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }

            portfolioManager.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = portfolioManager.TGetById(id);
            portfolioManager.TDelete(portfolio);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            ViewBag.v1 = "Proje Listeleme Sayfası";
            ViewBag.v2 = "Projelerim";
            ViewBag.v3 = "Proje Güncelleme";
            var portfolio = portfolioManager.TGetById(id);
            return View(portfolio);
        }

        [HttpPost]
        public IActionResult EditPortfolio(Portfolio p)
        {
            PortfolioValidator portfolioValidator = new();
            var result = portfolioValidator.Validate(p);

            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }

            portfolioManager.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}
