using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using Context context = new();
            ViewBag.projectCount = context.Portfolios.Count();
            ViewBag.messageCount = context.Messages.Count();
            ViewBag.serviceCount = context.Services.Count();
            return View();
        }
    }
}
