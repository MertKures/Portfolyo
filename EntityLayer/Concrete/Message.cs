using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public override string ToString()
        {
            return string.Format("Message ID: {0}\nName: {1}\nMail: {2}\nContent: {3}\nDate: {4}\nStatus: {5}", MessageID, Name, Mail, Content, Date, Status);
        }
    }
}
