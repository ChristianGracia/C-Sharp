using System;
using System.Collections.Generic;
using System.Linq;

namespace ListWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(33);
            list.Add(43);
            list.Add(0);
            list.Add(12);

            List<int> oddList = list.Where(x => x % 2 != 0).ToList();
            List<int> evenList = list.Where(x => x % 2 == 0).ToList();


            Console.WriteLine("Odds");
            foreach (int number in oddList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Even");
            foreach (int number in evenList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
