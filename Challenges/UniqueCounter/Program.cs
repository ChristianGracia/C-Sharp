using System;
using System.Collections.Generic;

namespace UniqueCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<string>();
            var flag = true;
            var uniqueCounter = -1;

            do
            {
                Console.WriteLine("input numbers to count uniques");
                var number = Console.ReadLine();
                if (number == "quit")
                    flag = !flag;
                Console.WriteLine("type 'quit' to stop and sort");


                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                    uniqueCounter++;
                }
                else
                {
                    numbers.Add(number);
                }
            }
            while (flag);

            Console.WriteLine("uniques: " + uniqueCounter);
        }
    }
}
