using System;
using System.Reflection;

namespace OptionalMethodParams
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPersonInfo("chris", 5);
            DisplayPersonInfo("jor", 11, "football");
        }

        public static void DisplayPersonInfo(string name, int age, string club = "hockey")
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(club);
        }
    }

}
