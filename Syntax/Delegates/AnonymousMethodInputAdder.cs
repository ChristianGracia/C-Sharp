using System;

namespace AnonMethodInputAdder
{
    delegate void AddNumsDelegate(int a, int b);
    delegate void AddNumInputDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the anonymous function integer adder");

            AddNumsDelegate adder = delegate ( int a , int b) { Console.WriteLine(a + b); };
            adder(4, 3);

            AddNumInputDelegate addInput = delegate()
            {
                Console.WriteLine("Enter a first number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{a} + {b} = {a + b}");
                Console.WriteLine(a + b);
            };
            addInput();
        }

    }
}
