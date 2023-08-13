using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Portfolyo.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("/Writer/Dashboard/")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserNameSurname = string.Concat(user.Name, " ", user.Surname);

            using (Context context = new Context())
            {
                ViewBag.UserCount = context.Users.Count();
                ViewBag.AnnouncementCount = context.Announcements.Count();
                ViewBag.MessageCount = context.UserMessages.Count();
                ViewBag.SkillCount = context.Skills.Count();
            }

            string apiKey = "d8b3695efda917cb695605a0c0517a81";
            string url = string.Concat("https://api.openweathermap.org/data/2.5/weather?q=Istanbul&appid=", apiKey, "&units=metric&lang=tr&mode=xml");

            try
            {
                XDocument document = XDocument.Load(url);
                ViewBag.Temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            }
            catch (System.Exception)
            {
                Debug.WriteLine("Hava durumu bilgisi alınamadı.");
            }

            return View();
        }
    }
}
