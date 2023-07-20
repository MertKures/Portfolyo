using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        public ContactManager _contactManager = new(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var value = _contactManager.TGetFirstOrDefault();
            if (value != null)
                return View(value);
            return View();
        }
    }
}
