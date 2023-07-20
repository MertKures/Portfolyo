using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class ProjectList : ViewComponent
    {
        PortfolioManager portfolioManager = new(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var projectList = portfolioManager.TGetList();
            return View(projectList);
        }
    }
}
