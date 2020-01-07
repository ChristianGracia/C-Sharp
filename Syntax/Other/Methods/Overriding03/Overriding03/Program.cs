using System;

namespace Overriding03
{
    class Program
    {
        static void Main(string[] args)
        {
            People[] people = new People[4];

            people[0] = new People();

            people[1] = new Joe();

            people[2] = new Brett();
            //gets overrides by parent method

            people[3] = new Dan();

            foreach (var person in people)
            {
                person.SayName();
            }
        }
    }

    public class People
    {
        public virtual void SayName()
        {
            Console.WriteLine("I don't have a name");
        }
    }

    public class Joe : People
    {
        public string Name = "Joe";

        public override void SayName()
        {
            Console.WriteLine("My name is " + Name);
        }
    }

    public class Brett : People
    {
        public string BrettName = "Brett";

        public void SayName()
        {
            Console.WriteLine("My name is " + BrettName);
        }
    }

    public class Dan : People
    {
        public string Name = "Dan";

        public override void SayName()
        {
            Console.WriteLine("My name is " + Name);
        }
    }
}