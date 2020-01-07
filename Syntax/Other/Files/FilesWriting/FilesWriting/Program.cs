using System;
using System.IO;

namespace FilesWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\temp\Names.txt";
            //append with true, rewrite without true overload
            Directory.CreateDirectory(@"C:\temp\names");
            StreamWriter sw = new StreamWriter(file, true);

            sw.WriteLine("Jack");
            sw.WriteLine("Joseph");
            sw.Close();

        }
    }
}
