using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager _aboutManager = new(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var values = _aboutManager.TGetList();
            return View(values);
        }
    }
}
