using System;

namespace SpeedChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input speed limit: ");

            var speedLimit = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Speed limit is " + speedLimit + " MPH");

            Console.WriteLine("\n\nInput car seen MPH: ");

            var speedCheck = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Reported " + speedCheck + " MPH");

            var demerits = 0;

            if (speedCheck < speedLimit)
                Console.WriteLine("\nokay");
            else
            {
                var difference = speedCheck - speedLimit;
                Console.WriteLine(difference);

                demerits = difference / 5;
                if (demerits > 12)
                    Console.WriteLine("Too high!\nLicense Suspended");
                else
                    Console.WriteLine("Demerits: " + demerits);
            }
        }
    }
}
