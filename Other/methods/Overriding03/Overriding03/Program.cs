using System;

namespace Overriding03
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new People();
            person.SayName();

            var joe = new Joe();
            joe.SayName();


            var brett = new Brett();
            brett.SayName();


            var Dan = new Dan();
            Dan.SayName();


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
