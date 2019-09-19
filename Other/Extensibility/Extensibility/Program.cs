using System;
using System.Dynamic;
using System.IO;

namespace Extensibility
{
    public class FileLogger : Ilogger
    {
        private readonly string _path;
        public FileLogger(string path)
        {
            _path = path;
            
        }
        public void LogError(string message)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(message);
            }
        }

        public void LogInfo(string message)
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           var dbMigrator = new DbMigrator(new ConsoleLogger());
           dbMigrator.Migrate();
        }
    }
}
