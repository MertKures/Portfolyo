using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal PortfolioDal)
        {
            _portfolioDal = PortfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public Portfolio? TGetFirstOrDefault()
        {
            return _portfolioDal.GetFirstOrDefault();
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
    }
}
