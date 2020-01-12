using System;
using System.Threading.Channels;

namespace ExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwoNumbers(1, 4));
            SayHi();
            Animals dog = new Animals();
            dog.Age = 11;
            Console.WriteLine(dog.Age);
        }

        public static void SayHi() => Console.WriteLine("hi");
        public static int AddTwoNumbers(int x, int y) => x + y;
    }

    class Animals
    {
        public Animals() => Console.WriteLine("New class created");
        private int age;

        public int Age
        {
            get => age;
            set => age = value;
        }
    }
}
