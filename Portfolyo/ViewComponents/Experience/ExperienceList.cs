using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        public ExperienceManager _experienceManager = new(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = _experienceManager.TGetList();
            return View(values);
        }
    }
}
