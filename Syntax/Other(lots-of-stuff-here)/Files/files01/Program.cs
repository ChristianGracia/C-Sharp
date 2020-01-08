using System;
using System.IO;

namespace files01
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\projects\etc\hi1.txt";


            //made file and copied text
            //File.Copy(@"c:\projects\etc\hi1.txt", @"c:\projects\etc\hi2.txt", true);

            //var content = File.ReadAllText(path);

            //Console.WriteLine(content);
            var path2 = @"c:\projects\etc\hi2.txt";
            //var content = File.ReadAllText(path2);
            //Console.WriteLine(content);

            var fileInfo = new FileInfo(path);

            //if (fileInfo.Exists)
            //{
            //Console.WriteLine("File exists");

            //}

            var info = fileInfo.CopyTo(path2);
            Console.WriteLine(info);
            //fileInfo.Delete();
            //File.Delete(path2);

            if (fileInfo.Exists)
            {
                Console.WriteLine("true");

            }
            Console.WriteLine("deleted");

            // to read with file

            //File.ReadAllText();
      
        }
    }
}
