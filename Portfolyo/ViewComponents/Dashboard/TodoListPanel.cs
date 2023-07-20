using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Portfolyo.ViewComponents.Dashboard
{
    public class TodoListPanel : ViewComponent
    {
        TodoListManager todoListManager = new(new EfTodoListDal());

        public IViewComponentResult Invoke()
        {
            var result = todoListManager.TGetList();
            return View(result);
        }
    }
}
