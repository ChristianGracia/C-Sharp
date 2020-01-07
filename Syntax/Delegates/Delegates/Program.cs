using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // void delegate with no argument

    // void delegate with one string argument

    // void delegate with one string argument and one int

    // string delegate with one int argument 

    public delegate void PlayerInfoDelegate();

    class Program
    {
        static void Main(string[] args)
        {

            PlayerInfoDelegate chris = new PlayerInfoDelegate(DisplayInformation);
            chris.Invoke();

        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Information about player : chris");
        }

        public static void DisplayInformation(string playerName)
        {
            Console.WriteLine("Information about player : " + playerName);
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about player : " + playerName + " and he score " + goals);
        }

        public static string DisplayInformation(int number)
        {
            string playerName = string.Empty;
            switch (number)
            {
                case 7: playerName = "chris"; break;
                case 8: playerName = "dan"; break;
                case 10: playerName = "joe"; break;
                default: break;
            }
            return playerName;
        }
    }
}
