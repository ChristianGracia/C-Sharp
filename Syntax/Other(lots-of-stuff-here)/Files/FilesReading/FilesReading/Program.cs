using System;

namespace FilesReading
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\temp\names.txt";
            System.IO.StreamReader sr = new System.IO.StreamReader(file);
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}
