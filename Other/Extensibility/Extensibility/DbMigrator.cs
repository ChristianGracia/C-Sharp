using System;

namespace Extensibility
{
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