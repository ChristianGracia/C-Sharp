using System;
using System.IO;

namespace directories01
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\projects\etc");

            var files = Directory.GetFiles(@"c:\projects\tmp\", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\tmp\", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
                Console.WriteLine(directory);

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
