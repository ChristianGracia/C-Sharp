using System;

namespace Extensibility
{
    public interface Ilogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
    public class DbMigrator
    {
        public void Migrate()
        {
            Console.WriteLine("migration started");
            // details of migration
            Console.WriteLine("migration finished");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
