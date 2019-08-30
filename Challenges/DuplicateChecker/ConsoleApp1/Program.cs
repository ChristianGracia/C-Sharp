using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFlag = true;
            Console.WriteLine("Enter a series of numbers seperated by a hyphen to check duplicates");
            var series = Console.ReadLine();
            if (series == "")
                inputFlag = false;
            if (inputFlag)
                Console.WriteLine("correct");
            else
                Console.WriteLine("Incorrect");
                
        }
    }
}
