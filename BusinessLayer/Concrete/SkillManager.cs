using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal SkillDal)
        {
            _skillDal = SkillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public List<Skill> TGetByFilter()
        {
            throw new System.NotImplementedException();
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetByID(id);
        }

        public Skill? TGetFirstOrDefault()
        {
            return _skillDal.GetFirstOrDefault();
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
