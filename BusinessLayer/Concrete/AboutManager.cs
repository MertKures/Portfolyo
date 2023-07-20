using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetByID(id);
        }

        public About? TGetFirstOrDefault()
        {
            return _aboutDal.GetFirstOrDefault();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
