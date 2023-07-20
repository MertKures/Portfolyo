using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
