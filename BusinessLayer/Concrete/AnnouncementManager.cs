using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TAdd(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public List<Announcement> TGetByFilter()
        {
            throw new System.NotImplementedException();
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.GetByID(id);
        }

        public Announcement TGetFirstOrDefault()
        {
            return _announcementDal.GetFirstOrDefault();
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public void TUpdate(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
