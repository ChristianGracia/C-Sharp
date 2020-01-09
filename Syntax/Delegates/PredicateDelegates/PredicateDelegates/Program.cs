using System;

namespace PredicateDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> condition = IsAdmin;
            Console.WriteLine(condition(10));
            Console.WriteLine(condition(1));

        }

        public static bool IsAdmin(int employeeNum)
        {
            if (employeeNum == 10)
            {
                return true;
            }

            return false;
        }
    }
}
