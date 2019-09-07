using System;
using System.IO;

namespace directories01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"c:\projects\tmp");

            var files = Directory.GetFiles(@"c:\projects\etc\", "*.*", SearchOption.AllDirectories);
            //foreach (var file in files)
                //Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\", "*.*", SearchOption.AllDirectories);

            //foreach (var directory in directories)
                //Console.WriteLine(directory);

            var directoryInfo = new DirectoryInfo(@"\projects\");
            Console.WriteLine(directoryInfo.GetFiles());
           
            directoryInfo.GetDirectories();

        }
    }
}
