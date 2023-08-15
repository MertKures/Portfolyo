using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Writer.ViewComponents
{
    public class ProfileNavbar : ViewComponent
    {
        UserManager<WriterUser> _userManager;

        public ProfileNavbar(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ProfilePicture = user.ImageUrl;
            return View();
        }
    }
}
