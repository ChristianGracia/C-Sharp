using System;
using System.IO;

namespace RecursionFolderDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = string.Empty;
            path = @"C:\Users\chris\Document";
            Console.WriteLine(path);
            DisplayFolders(path, 0);
        }

        private static void DisplayFolders(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                DisplayFolders(folder, indent + 2);
            }
        }
    }
}
