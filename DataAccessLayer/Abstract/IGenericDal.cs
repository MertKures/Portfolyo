using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T GetByID(int id);
        List<T> GetList();
        T? GetFirstOrDefault();
    }
}
