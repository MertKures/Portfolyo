using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        public PortfolioManager _portfolioManager = new(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = _portfolioManager.TGetList();
            return View(values);
        }
    }
}
