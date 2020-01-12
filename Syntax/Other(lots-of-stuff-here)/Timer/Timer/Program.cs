using System;
using System.Timers;

namespace Timers
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Elapsed += OnEachSecond;
            timer.Interval = 2000;
            timer.Enabled = true;
            Console.WriteLine("press x to exit");
            while (Console.Read() != 'x') ;
        }

        private static void OnEachSecond(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Yes it is working " + DateTime.Now.ToLongTimeString());
        }
    }
}
