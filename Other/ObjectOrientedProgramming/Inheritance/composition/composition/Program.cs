using System;

namespace composition
{
    public class Installer
    {
        
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
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