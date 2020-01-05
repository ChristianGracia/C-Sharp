using System;

namespace ConsoleColors
{
    class Program
    {
        static void Main(string[] args)
        {
            string blueMessage = "This is blue";
            string greenMessage = "This is green";
            string redMessage = "This is red";

            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(greenMessage);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(redMessage);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(blueMessage);
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
