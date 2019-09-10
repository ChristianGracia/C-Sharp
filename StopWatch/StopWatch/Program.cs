using System;
using System.Dynamic;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press start to start!");
     
            var startTime = DateTime.Now;
            var timer = new Stopwatch(startTime);

            var total = timer.StopTimer;

            Console.WriteLine(total);
         
        }
    }
}
