using System;

namespace MulticastDelegateMathOps
{
    delegate int DoMathDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            DoMathDelegate solver = null;
            solver += new DoMathDelegate(AddTwoNums);
            solver += new DoMathDelegate(SubtractTwoNums);
            solver += new DoMathDelegate(DivideTwoNums);
            solver += new DoMathDelegate(MultiplyTwoNums);
            solver += new DoMathDelegate(RemainderTwoNums);
            Console.WriteLine(solver(10, 100));

         


        }

        private static readonly Func<int, int, int> AddTwoNums = (x, y) => x + y;
        

        private static readonly Func<int, int, int> SubtractTwoNums = (x,y) => x - y;
        

        private static readonly Func<int, int, int> DivideTwoNums = ( x, y) =>  x / y;


        private static readonly Func<int, int, int> MultiplyTwoNums = (x, y) => x * y;

        private static readonly Func<int, int, int> RemainderTwoNums = (x ,y) =>  x % y;
        
    }

}
