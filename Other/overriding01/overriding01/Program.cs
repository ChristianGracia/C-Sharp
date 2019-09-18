using System;

namespace overriding01
{
    class Program
    {
        static void Main(string[] args)
        {
           var circle = new Circle();
           circle.Draw();
        }
    }

    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("shape method");
        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("circle method");
        }

    }
}
