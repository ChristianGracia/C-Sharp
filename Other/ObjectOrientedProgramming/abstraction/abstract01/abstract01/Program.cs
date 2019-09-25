using System;

namespace abstract01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.SayShape();
            circle.Draw();
            


            
        }
    }

    abstract  class Shapes
    {
        abstract public void Draw();
        public void SayShape()
        {
            Console.WriteLine("hi");
        }

    }

     class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("circle");
        }
    }
}
