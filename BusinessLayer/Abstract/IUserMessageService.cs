using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IUserMessageService : IGenericService<UserMessage>
    {
        List<UserMessage> GetUserMessageWithUserService();
    }
}
