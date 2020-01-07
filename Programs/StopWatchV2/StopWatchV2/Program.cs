using System;
using System.Diagnostics;

namespace StopWatchV2
{
    class Program
    {
        static void Main(string[] args)
        {
     
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("Time: 00:00:00.0000000");
          
            watch.Start();
            Loop(900_000_000);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
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
