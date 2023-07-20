using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
