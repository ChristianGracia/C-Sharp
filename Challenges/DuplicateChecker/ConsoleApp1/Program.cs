using System;
using System.Collections.Generic;

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

            if (!inputFlag)
                Console.WriteLine("Incorrect");
            else
            {
                Console.WriteLine("input: " + series);
                var numberArray = series.Split("-");
                var numberList = new List<int>();

                for (var i = 0; i < numberArray.Length - 1; i++)
                {
                    if (numberList.Contains(Convert.ToInt32(numberArray[i])))
                        Console.WriteLine("duplicates");

                    numberList.Add(Convert.ToInt32(numberArray[i]));
                }        
            }
        }
    }
}
