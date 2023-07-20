using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using Context c = new();
            ViewBag.skillCount = c.Skills.Count();
            ViewBag.messagesReadCount = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.messagesUnreadCount = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.experiencesCount = c.Experiences.Count();
            return View();
        }
    }
}
