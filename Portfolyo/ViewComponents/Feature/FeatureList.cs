using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager _featureManager = new(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values = _featureManager.TGetList();
            return View(values);
        }
    }
}
