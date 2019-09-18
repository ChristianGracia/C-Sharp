using System;

namespace ArrayConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter path of text file to be converted to array: \n");
            var path = "C:\\projects\\etc\\lorem.txt";
            string text = System.IO.File.ReadAllText(path);
            Console.WriteLine(text);



            //var newArray = text.Trim().Split();
            //Console.WriteLine(newArray);
        }
    }
}
