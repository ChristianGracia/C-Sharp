using System;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press start to start!");
       
            var startTime = DateTime.Now;

            var startTime1 = new Stopwatch(DateTime.Now);

        }
    }

    public class Stopwatch
    {
        public DateTime StartTime { get; set; }

        public DateTime Start(DateTime startTime)
        {
            return startTime;

        }



    }

}
