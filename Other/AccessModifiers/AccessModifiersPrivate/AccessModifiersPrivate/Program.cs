using System;
using System.Collections.Specialized;
using Library;

namespace AccessModifiersPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Customer();
            person.Promote();
            Console.WriteLine();
        }
    }
}
