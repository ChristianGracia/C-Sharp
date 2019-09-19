using System;
using System.Runtime.InteropServices;

namespace polymorphism02
{
    public class VideoEncoder
    {
        private readonly MailService _mailService;

        public VideoEncoder()
        {
            _mailService = new MailService();
        }

        public void Encode(Video video)
        {
            //video encoding logic
            _mailService.Send(new Mail());
        }
    }

    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("sending email");
        }
        
    }
}