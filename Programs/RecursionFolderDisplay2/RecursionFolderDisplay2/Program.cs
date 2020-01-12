using System;
using System.IO;
using System.Net;

namespace RecursionFolderDisplay2
{

    delegate void DisplayFileInfoDelegate(string path, int indent);
    class Program
    {
        static void Main(string[] args)
        {
            string path = string.Empty;
            path = @"C:\temp\";

            DisplayFileInfoDelegate displayFiles = new DisplayFileInfoDelegate(DisplayFolders);
            displayFiles(path, 0);

        }

        private static void DisplayFolders(string path, int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.Write($"Folder: {new string(' ', indent)} {Path.GetFileName(folder)}");
                Console.Write($"{new string(' ', indent)} {Directory.GetCreationTime( folder)}");
                Console.WriteLine();
                foreach (var file in Directory.GetFiles(folder))
                {
                    Console.WriteLine($"File name:" +
                                      $" {new string(' ', indent)} {Path.GetFileName(file)}");

                    Console.WriteLine($"Created on {new string(' ', indent)} {File.GetCreationTime(file).ToLongDateString()}");
                }
                DisplayFolders(folder, indent + 2);
            }
        }
    }
}
