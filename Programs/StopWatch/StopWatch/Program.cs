using System;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            string answer;
            do
            {
                Console.WriteLine("\nstart, stop, or quit timer?");
                answer = Console.ReadLine();
                if (answer == "start")
                {
                    timer.Start();
                }

                else if (answer == "stop")
                {
                    timer.Stop();
                    TimeSpan addedTime = timer.StopTimer;
                    Console.WriteLine("Total time: " + timer.StopTimer);
                    timer.AddTime(addedTime);
                }
                else if (answer == "quit")
                    break;
            } while (true);
        }
    }
}