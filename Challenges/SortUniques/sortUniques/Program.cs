using System;

namespace sortUniques
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
         
            for (var x = 0; x < 5;) {
                Console.WriteLine("Put 5 unique numbers to be sorted: ");
                var number = Int32.Parse(Console.ReadLine());

                if (Array.IndexOf(numbers, number) < 0)
                {
                    numbers[x] = number;
                    x++;
                }

                else
                    Console.WriteLine("invalid input, please put in unique name");
            }
           Array.Sort(numbers);

            foreach (var x in numbers)
                Console.WriteLine(x);
        }
    }
}
