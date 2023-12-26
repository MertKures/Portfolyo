using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetReceiversMessages(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetSendersMessages(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(WriterMessage t)
        {
            throw new System.NotImplementedException();
        }

        public List<WriterMessage> TGetByFilter()
        {
            throw new System.NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetByID(id);
        }

        public WriterMessage TGetFirstOrDefault()
        {
            throw new System.NotImplementedException();
        }

        public List<WriterMessage> TGetList()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new System.NotImplementedException();
        }
    }
}
