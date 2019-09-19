using System;
using System.Drawing;

namespace multipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            Console.WriteLine("Received focus");
        }
    }
}
