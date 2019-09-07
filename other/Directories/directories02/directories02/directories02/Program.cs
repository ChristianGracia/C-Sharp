using System;
using System.IO;
using System.Runtime.InteropServices;

namespace directories02
{
    class Program
    {
        static void Main(string[] args)
        {

       

            var path = @"C:\Projects\etc\hi.txt";

            Console.WriteLine("extension = " + Path.GetExtension(path));

        }
    }
}
