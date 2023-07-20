using BusinessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    interface IMessageService : IGenericService<Message>
    {
    }
}
