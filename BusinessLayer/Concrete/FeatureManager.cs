using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public List<Feature> TGetByFilter()
        {
            throw new System.NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetByID(id);
        }

        public Feature? TGetFirstOrDefault()
        {
            return _featureDal.GetFirstOrDefault();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
