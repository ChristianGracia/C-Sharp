using System;

namespace inheritance02
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("object copied");

        }

        public void Duplicate()
        {
            Console.WriteLine("object was duplicated");

        }
    }
}