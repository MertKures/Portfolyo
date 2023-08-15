using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Portfolyo.Areas.Writer.ViewComponents
{
    public class Notifications : ViewComponent
    {
        AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IViewComponentResult Invoke()
        {
            var result = _announcementManager.TGetList().Take(5).ToList();
            return View(result);
        }
    }
}
