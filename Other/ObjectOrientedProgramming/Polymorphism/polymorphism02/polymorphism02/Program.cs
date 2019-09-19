using System;
using System.Net.Mail;

namespace polymorphism02
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.Encode(new Video());
        }
    }
}

