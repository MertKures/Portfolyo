using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IWriterMessageService : IGenericService<WriterMessage>
    {
        public List<WriterMessage> GetSendersMessages(string p);
        public List<WriterMessage> GetReceiversMessages(string p);
    }
}
