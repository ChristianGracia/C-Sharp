using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\etc\hi1.txt";
            var content = new FileInfo(path);
            Console.WriteLine(content);

        }
    }
}
