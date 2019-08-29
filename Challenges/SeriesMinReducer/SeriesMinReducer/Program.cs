using System;
using System.Collections.Generic;
namespace SeriesMinReducer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] series;
  
            Console.WriteLine("Input a series of numbers");
            series = Console.ReadLine();
           
            foreach(var x in series)
                Console.WriteLine(x);




        }
    }
}
