using System;

namespace downcasting01
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            //only get shape props and methods not Text's, so need downcast
            Text text = (Text) shape;
            //   ^ gets var to have class and methods of both text and shape class with downcast

            


        }
    }
}