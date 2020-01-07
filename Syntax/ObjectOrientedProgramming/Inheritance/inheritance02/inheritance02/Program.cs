using System;

namespace inheritance02
{
    //: points to inherit from Presentation Object
    class Program
    {
        static void Main(string[] args)
        {
            //inherits methods from presentation object class
            //also inherits the members of object class
            var text = new Text();
            text.width = 100;
            text.Copy();
        }
    }
}
