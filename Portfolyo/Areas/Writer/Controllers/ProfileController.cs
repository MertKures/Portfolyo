using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Areas.Writer.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel
            {
                Name = user.Name,
                Surname = user.Surname,
                PictureURL = user.ImageUrl
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel arg)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (arg.Picture != null)
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var filename = string.Concat(Guid.NewGuid().ToString(), Path.GetExtension(arg.Picture.FileName));
                var path = Path.Combine(currentDirectory, "wwwroot/userimage/", filename);
                var stream = new FileStream(path, FileMode.Create);
                await arg.Picture.CopyToAsync(stream);
                user.ImageUrl = filename;
            }

            user.Name = arg.Name;
            user.Surname = arg.Surname;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(user);
        }
    }
}
