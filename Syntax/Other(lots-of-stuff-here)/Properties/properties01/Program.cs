using System;
using System.Dynamic;

namespace properties01
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            person.Name = "chris";
            Console.WriteLine(person.Name);
            person.Name = "chrssis";
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
