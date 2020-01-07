using System;
using System.Diagnostics;

namespace StopWatchV2
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Stopwatch watch = new Stopwatch();

            long num = 900_000_000;
            Console.WriteLine("Timing function.... n = " + num);
          
            watch.Start();
            Loop(num);
            watch.Stop();

            Console.WriteLine("seconds: " + watch.Elapsed.Seconds);
            Console.WriteLine("milliseconds: " + watch.Elapsed.Milliseconds);
            Console.WriteLine("total milliseconds: " + watch.Elapsed.TotalMilliseconds);
        }

        public static void Loop(long number)
        {
            for (long i = 0; i < number; i++)
            {

            }
            Console.WriteLine("Process Complete");
        }
    }
}
