using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class WriterMessage
    {
        [Key]
        public int WriterMessageID { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        // "Content" ismi özel mesaj olarak algılandığından onu kullanmadık.
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
