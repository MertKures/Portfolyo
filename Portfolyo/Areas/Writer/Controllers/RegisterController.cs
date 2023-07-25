using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolyo.Areas.Writer.Models;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            // Türkçe karakter kullanılmayacak
            // Şifre 6 karakter veya daha uzun olacak
            // Şifrede en az 1 büyük harf, 1 küçük harf, 1 sayı ve 1 özel karakter olacak
            if (ModelState.IsValid)
            {
                WriterUser writer = new WriterUser()
                {
                    Name = p.Name,
                    Surname = p.Surname,
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImageUrl = p.ImageUrl
                };

                // ModelState.IsValid kullanıldığından bu kontrolün yapılmasına gerek yok.
                //if (p.Password == p.ConfirmPassword)
                var result = await _userManager.CreateAsync(writer, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(p);
        }
    }
}
