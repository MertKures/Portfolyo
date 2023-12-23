using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public List<Service> TGetByFilter()
        {
            throw new System.NotImplementedException();
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetByID(id);
        }

        public Service? TGetFirstOrDefault()
        {
            return _serviceDal.GetFirstOrDefault();
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
