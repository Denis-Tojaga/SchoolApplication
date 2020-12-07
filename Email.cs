using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Email
    {
        public int EmailID { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string Content { get; set; }
        public Attachment File { get; set; }


        public override string ToString()
        {
            return $"{Content}";
        }
    }
}
