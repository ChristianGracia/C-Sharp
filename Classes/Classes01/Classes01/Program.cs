using System;

namespace Classes01
{
    public class Person
    {
        public string Name;

        public void Introduce(string person2)
        {
            Console.WriteLine("hi {0}, This is {1}", person2, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("john");
            person.Introduce("jake");
            
        }
    }
}