using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Contact
{
    public class ContactList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
