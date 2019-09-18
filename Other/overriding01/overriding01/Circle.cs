using System;

namespace overriding01
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("circle method");
        }

    }
}