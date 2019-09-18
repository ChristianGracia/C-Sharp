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
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                      //draw circle
                        break;

                    case ShapeType.Rectangle:
                       //draw rectangle
                        break;

                }
            }

        }
    }


}