using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class TodoListManager : ITodoListService
    {
        ITodoListDal _todoListDal;

        public TodoListManager(ITodoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public void TAdd(TodoList t)
        {
            _todoListDal.Insert(t);
        }

        public void TDelete(TodoList t)
        {
            _todoListDal.Delete(t);
        }

        public TodoList TGetById(int id)
        {
            return _todoListDal.GetByID(id);
        }

        public TodoList TGetFirstOrDefault()
        {
            return _todoListDal.GetFirstOrDefault();
        }

        public List<TodoList> TGetList()
        {
            return _todoListDal.GetList();
        }

        public void TUpdate(TodoList t)
        {
            _todoListDal.Update(t);
        }
    }
}
