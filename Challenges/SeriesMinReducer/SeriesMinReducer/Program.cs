using System;
using System.Collections.Generic;
namespace SeriesMinReducer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
 
            while (true)
            {
                Console.WriteLine("Enter a series of at least 5 numbers to be sorted: ");
                var answer = Console.ReadLine().Split(',');

                foreach (var x in answer)
                    numbers.Add(Int32.Parse(x.Trim()));
         
                if (numbers.Count > 4)
                    break;
                Console.WriteLine("\nInvalid List!\n");
            }
            var array = new int[numbers.Count];

            for (var i = 0; i <numbers.Count; i++)
            {
                array[i] = numbers[i];
            }

            Array.Sort(array);

            var minArray = new int[3];
            Array.Copy(array, minArray, 3);

            Console.Write("'");
            var counter = 0;
            foreach (var x in minArray)
            {
                if (counter != 0)
                    Console.Write(", " + x);
                else
                {
                    counter++;
                    Console.Write(x);
                }
            }
            Console.Write("'");
            Console.WriteLine(" are the mins");
        }
    }
}
