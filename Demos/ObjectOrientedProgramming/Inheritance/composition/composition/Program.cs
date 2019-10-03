using System;

namespace composition
{
    public class Program
    {
        static void Main(string[] args)
        {
            var db = new Migrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            db.Migrate();
            installer.Install();

        }
        
    }
}