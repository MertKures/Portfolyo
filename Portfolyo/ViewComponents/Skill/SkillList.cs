using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Skill
{
    public class SkillList : ViewComponent
    {
        SkillManager _skillManager = new(new EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values = _skillManager.TGetList();
            return View(values);
        }
    }
}
