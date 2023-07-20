using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void TAdd(T t);
        public void TDelete(T t);
        public void TUpdate(T t);
        public T TGetById(int id);
        public List<T> TGetList();
        public T? TGetFirstOrDefault();
    }
}
