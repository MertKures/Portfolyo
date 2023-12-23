using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal ExperienceDal)
        {
            _experienceDal = ExperienceDal;
        }

        public void TAdd(Experience t)
        {
            _experienceDal.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.GetList();
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }

        public Experience? TGetFirstOrDefault()
        {
            return _experienceDal.GetFirstOrDefault();
        }

        public List<Experience> TGetByFilter()
        {
            throw new System.NotImplementedException();
        }
    }
}
