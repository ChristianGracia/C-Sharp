namespace composition
{
    public class Migrator
    {
        private readonly Logger _logger;

        public Migrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("migrating");
        }
    }

}