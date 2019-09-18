using System;

namespace interfaces01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public interface ITaxCalculator
    {
        //interface instead of class prefix
        //I before name
        //no access modifiers
        //no implementation, just declaration, no body
        int Calculate();
        //allow more loose coupling due to less code
    }
}
