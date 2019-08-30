using System;

namespace TimeSpan1
{
    class Program
    {
        static void Main(string[] args)
        {

            // creation
            var time = new TimeSpan(1, 2, 3);

            var time1 = TimeSpan.FromHours(1);

            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddMinutes(2);

            var duration = endDate - startDate;
            Console.WriteLine(duration);

            // properties
            Console.WriteLine("Minutes: " + time.Minutes);
            Console.WriteLine("Minutes: " + time.TotalMinutes);

            // add
            Console.WriteLine("Add: " + time.Add(TimeSpan.FromMinutes(8)));

            // substract
            Console.WriteLine("Subtract: " + time.Subtract(TimeSpan.FromMinutes(2)));

            // to string
            Console.WriteLine("String: " + time.ToString());

            // parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
       
 



        }
    }
}
