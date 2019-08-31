using System;

namespace OddNumberDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers seperated by commas for the odd numbers to be removed");
            var inputSeries = Console.ReadLine().Trim();
            var inputArray = inputSeries.Split(",");

            for (var i = 0; i < inputSeries.Length /3; i++)
            {
                Console.WriteLine(inputArray[i]);
            }




        }
    }
}
