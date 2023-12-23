using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(User t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public List<User> TGetByFilter()
        {
            throw new System.NotImplementedException();
        }

        public User TGetById(int id)
        {
            return _userDal.GetByID(id);
        }

        public User TGetFirstOrDefault()
        {
            return _userDal.GetFirstOrDefault();
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
