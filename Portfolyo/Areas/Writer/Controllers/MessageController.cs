using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string receiverEmail)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            receiverEmail = values.Email;

            var messageList = _writerMessageManager.GetReceiversMessages(receiverEmail);

            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage(string senderEmail)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            senderEmail = values.Email;

            var messageList = _writerMessageManager.GetSendersMessages(senderEmail);

            return View(messageList);
        }
    }
}
