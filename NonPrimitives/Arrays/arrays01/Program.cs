using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            var flags = new bool[3];

            flags[0] = true;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(flags[i]);
            }

            var names = new string[3] { "Andrew", "Andy", "Ders"};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(names[i]);
            }
  
        }
    }
}
