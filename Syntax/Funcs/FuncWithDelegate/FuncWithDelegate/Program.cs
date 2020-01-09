using System;

namespace FuncWithDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> addWithParams = AddTwoNums;
            Console.WriteLine(AddTwoNums(3, 5));

            Func<int> addWithoutParams = AddTwoNums;
            Console.WriteLine(addWithoutParams());

        }

        public static int AddTwoNums()
        {
            int x = 8;
            int y = 7;
            int z = 0;

            z = x + y;

            return z;


        }

        public static int AddTwoNums(int a, int b)
        {
            return a + b;
        }
        

    }
}
