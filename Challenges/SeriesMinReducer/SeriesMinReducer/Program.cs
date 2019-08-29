using System;
using System.Collections.Generic;
namespace SeriesMinReducer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
    
            Console.WriteLine("Enter a series of numbers to be sorted: ");
            var answer = Console.ReadLine().Split(',');

            foreach (var x in answer)
            {
                numbers.Add(Int32.Parse(x.Trim()));
       
            }

        }
    }
}
