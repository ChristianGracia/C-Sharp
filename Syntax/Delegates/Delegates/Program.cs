using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // void delegate with no argument
    public delegate void PlayerInfoDelegate();
    // void delegate with one string argument
    public delegate void PlayerInfoDelegateWithName(string playerName);
    // void delegate with one string argument and one int
    public delegate void PlayerInfoDelegateWithScore(string playerName, int score);
    // string delegate with one int argument 
    public delegate string PlayerNameDelegate(int number);



    class Program
    {
        static void Main(string[] args)
        {

            PlayerInfoDelegate chris = new PlayerInfoDelegate(DisplayInformation);
            chris.Invoke();


            PlayerInfoDelegateWithName playerName = new PlayerInfoDelegateWithName(DisplayInformation);
            playerName("joe");


            PlayerInfoDelegateWithScore player = new PlayerInfoDelegateWithScore(DisplayInformation);
            player("jake", 12);


            PlayerNameDelegate name = new PlayerNameDelegate(DisplayInformation);
            Console.WriteLine(name(7));


        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Information about player : chris");
        }

        public static void DisplayInformation(string playerName)
        {
            Console.WriteLine("Information about player : " + playerName);
        }

        public static void DisplayInformation(string playerName, int score)
        {
            Console.WriteLine("Information about player : " + playerName + " and he scored " + score);
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
