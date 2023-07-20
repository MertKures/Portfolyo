using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceManager _serviceManager = new(new EfServiceDal());

        public IViewComponentResult Invoke()
        {
            var values = _serviceManager.TGetList();
            return View(values);
        }
    }
}
