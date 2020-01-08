using System;
using System.Security.Cryptography.X509Certificates;

namespace LambdaExpression
{
    delegate int Multiply(int n);

    delegate void DisplayMessage();
    class Program
    {
        static void Main(string[] args)
        {
            
            //Multiply MultiplyNumber = delegate(int n) { { return n * 3; } };

            //faster version with lambda
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(10));


            //DisplayMessage Message = delegate { Console.WriteLine("hi"); };
            DisplayMessage Message = () => Console.WriteLine("hi from lambda");
            Message();
            
        }
    }

}
