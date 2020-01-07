using System;
using System.Collections.Generic;

namespace override02
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                //polymorphism
                shape.Draw();
            }
        }
    }


}