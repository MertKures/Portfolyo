using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        public TestimonialManager _testimonialManager = new(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = _testimonialManager.TGetList();
            return View(values);
        }
    }
}
