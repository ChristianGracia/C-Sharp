using System;
using System.Net.Mail;

namespace polymorphism02
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            //polymorphic behavior
            //VideoEncoder class doesnt need to change when we add new channels
            encoder.RegisterNotificationChannel(new MailNotifcationChanell());
            encoder.RegisterNotificationChannel(new SmsNotifcationChannel());
            encoder.Encode(new Video());
        }
    }
}

