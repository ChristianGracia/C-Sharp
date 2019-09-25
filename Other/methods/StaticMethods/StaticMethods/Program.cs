using System;

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //has to be used if not static in main
            //var p = new Program();
            //p.StaticMethod();
        }

        static void StaticMethod()
        {
            Console.WriteLine("this is static and doesn't need an instance of the class to be used");

       
        }
    }
}
