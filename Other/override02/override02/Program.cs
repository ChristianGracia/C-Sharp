using System;
using System.Collections.Generic;

namespace override02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType circle:
                        Console.WriteLine("draw a circle");
                        break;
                    case ShapeType.Rectangle:
                        Console.WriteLine("draw a rectangle");
                        break;

                }
            }

        }
    }
}
