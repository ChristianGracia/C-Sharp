using System;
using System.Dynamic;

namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
           var dbMigrator = new DbMigrator(new ConsoleLogger());
           dbMigrator.Migrate();

           //first had console logging
           //added file logging without changing any previous code
           //with a new class that writes messages to a file instead
        }
    }
}
