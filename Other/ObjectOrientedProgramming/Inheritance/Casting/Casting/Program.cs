using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ////upcast
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);

            ////text.width = 100 because text and shape
            ////reference the same object. just dif views


            ////this gets upcasted to its parent class: stream
            ////any class that derives from stream class
            //StreamReader reader = new StreamReader(new FileStream());



            //this may get exceptions when compiled 
            //due to changing types in arrays
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Mosh");
            arrayList.Add(new Text());

            //use lists instead because controlled types
            var anotherList = new List<Shape>();

        }
    }
}
