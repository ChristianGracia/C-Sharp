using System;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press start to start!");
       
            var startTime = DateTime.Now;

            var start = new Stopwatch(startTime);
            Console.WriteLine(start.StartTime);

        }
    }
}
