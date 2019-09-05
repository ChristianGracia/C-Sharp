using System;
using System.IO;

namespace files01
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myFile.jpg", @"d:\temp\myFile.jpg",true);

            File.Delete(path);

            if (File.Exists(path))
            {
                // do something
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //use filestream for fileInfo 
            }

            // to read with file
            File.ReadAllText();
        }
    }
}
