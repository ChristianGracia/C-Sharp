using System;

namespace Extensibility
{
    public class ConsoleLogger : Ilogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
    public class DbMigrator
    {
        private readonly Ilogger _logger;
        public DbMigrator(Ilogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("migration started at " + DateTime.Now);
            
            _logger.LogInfo("migration finished at " + DateTime.Now);
        }
    }
}