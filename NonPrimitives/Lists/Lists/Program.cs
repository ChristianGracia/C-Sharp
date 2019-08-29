using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var x in numbers)
                Console.WriteLine(x);

            // last index
            Console.WriteLine(numbers.LastIndexOf(1));
            Console.WriteLine("count: " + numbers.Count);

            // remove all 1's
            numbers.Remove(1);

            //not allowed (doesn't work)

            //foreach (var x in numbers)
                //if (x == 1)
                    //numbers.Remove(x);

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }


            foreach(var x in numbers)
                Console.WriteLine(x);

            // clear list
            numbers.Clear();
            Console.WriteLine(numbers.Count);
        }
    }
}
