using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        UserMessageManager messageManager = new(new EfUserMessageDal());

        public IViewComponentResult Invoke()
        {
            var messageList = messageManager.GetUserMessageWithUserService();
            return View(messageList);
        }
    }
}
