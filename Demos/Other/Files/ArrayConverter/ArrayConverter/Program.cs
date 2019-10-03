using System;

namespace   WordReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter path of text file to be converted to array: \n");
            var path = "C:\\projects\\etc\\lorem.txt";
            string text = System.IO.File.ReadAllText(path);
            text.Split("\n");
            foreach (var item in text)
            {
                Console.WriteLine(item);
                
            }



            //var newArray = text.Trim().Split();
            //Console.WriteLine(newArray);
        }
    }
}
