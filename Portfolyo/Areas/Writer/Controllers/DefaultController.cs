using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        [HttpGet("/Writer/")]
        public IActionResult Index()
        {
            var result = _announcementManager.TGetList();
            return View(result);
        }

        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            var value = _announcementManager.TGetById(id);
            return View(value);
        }
    }
}
