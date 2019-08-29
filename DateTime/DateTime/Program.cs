using System;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2017, 1, 1);
            //Console.WriteLine(dateTime);

            var now = DateTime.Now;
            //Console.WriteLine("now is " + now);

            var today = DateTime.Today;
            //Console.WriteLine("today is " + today);

            var hour = now.Hour;
            var minute = now.Minute;

            // immutable

            var tomorrow = now.AddDays(1);
            //Console.WriteLine(tomorrow);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            //Console.WriteLine(now.ToString());


            //Console.WriteLine(hour + ":" + minute);
        }
    }
}
