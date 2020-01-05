using System;

namespace constructors01
{
    class Program
    {
        static void Main(string[] args)
        {
       
            var p = new Person("chris", 12);
            Console.WriteLine(p.Name + ",  " + p.Age);

            var p1 = new Person("lol", 34);
            Console.WriteLine(p1.Name + ",  " + p1.Age);

            var p2 = new Person("harry");
            Console.WriteLine(p2.Name);

        }
    }

    public class Person
    {
        public string Name;
        public int Age;

        //overload
        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
