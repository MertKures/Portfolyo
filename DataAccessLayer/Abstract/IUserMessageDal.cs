using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IUserMessageDal : IGenericDal<UserMessage>
    {
        List<UserMessage> GetUserMessagesWithUser();
    }
}
