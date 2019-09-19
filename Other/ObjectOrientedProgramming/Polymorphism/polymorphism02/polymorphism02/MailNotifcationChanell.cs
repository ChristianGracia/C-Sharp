using System;

namespace polymorphism02
{
    public class MailNotifcationChanell : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending mail");
        }
    }
}