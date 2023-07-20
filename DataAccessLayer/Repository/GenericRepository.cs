using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public GenericRepository()
        {

        }

        public void Delete(T t)
        {
            using Context c = new();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using Context c = new();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using Context c = new();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using Context c = new();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using Context c = new();
            c.Update(t);
            c.SaveChanges();
        }

        public T GetFirstOrDefault()
        {
            using Context c = new();
            return c.Set<T>().FirstOrDefault();
        }
    }
}
