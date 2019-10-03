using System;

namespace override02
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw rectangle logic");
        }
    }
}