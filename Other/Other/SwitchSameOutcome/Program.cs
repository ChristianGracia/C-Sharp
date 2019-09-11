using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Summer;

            switch(season)
            {
                // if two case statements have same outcome
                case Season.Autmn:
                case Season.Summer:
                    Console.WriteLine("We have a sale going on");
        
                deafault:
                    Console.WriteLine("?");
            }

        }
    }
}
