using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager = new(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var result = portfolioManager.TGetList();
            return View(result);
        }
    }
}
