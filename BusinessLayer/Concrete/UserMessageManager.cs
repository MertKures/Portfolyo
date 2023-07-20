using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public void TAdd(UserMessage userMessage)
        {
            _userMessageDal.Insert(userMessage);
        }

        public void TDelete(UserMessage userMessage)
        {
            _userMessageDal.Delete(userMessage);
        }

        public void TUpdate(UserMessage userMessage)
        {
            _userMessageDal.Update(userMessage);
        }

        public UserMessage TGetById(int id)
        {
            return _userMessageDal.GetByID(id);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public UserMessage TGetFirstOrDefault()
        {
            return _userMessageDal.GetFirstOrDefault();
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUser();
        }
    }
}
