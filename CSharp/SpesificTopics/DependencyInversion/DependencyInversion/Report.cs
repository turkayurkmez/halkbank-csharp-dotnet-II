using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{

    public interface ISender
    {
        void Send();
    }
    public class Report
    {
        private ISender sender;
        public Report(ISender sender)
        {
            this.sender = sender;
        }
        //  public MailSender MailSender { get; set; }
        public void Send()
        {
            sender.Send();
        }
    }

    public class MailSender : ISender
    {
        public void Send() => Console.WriteLine("Eposta gönderildi!");
    }

    public class WhatsAppSender : ISender
    {
        public void Send() => Console.WriteLine("Whatsapp gönderildi!");
    }

    public class TelegramSender : ISender
    {
        public void Send() => Console.WriteLine("Telegram gönderildi!");
    }
}
