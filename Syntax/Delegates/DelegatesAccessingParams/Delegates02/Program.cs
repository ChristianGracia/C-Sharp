using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates02
{
    // void delegate with one string argument and one int
    public delegate void PlayerInformationWithScore(string playerName, int playerGoals);

    // string delegate with one int argument and one string
    public delegate string PlayerInformationBasedOnNumberAndClub(int playerNo, string club, string country = "Unknown");


    class Program
    {
        static void Main(string[] args)
        {
            PlayerInformationWithScore playerOne = new PlayerInformationWithScore(DisplayInformation);
            PlayerInformationBasedOnNumberAndClub playerTwo = new PlayerInformationBasedOnNumberAndClub(DisplayInformation);
            //playerOne("chris", 20);
            //playerTwo(7, "cool");
            
            Console.WriteLine(playerTwo.Method);

            foreach (var item in playerTwo.Method.GetParameters())
            {
                Console.WriteLine($"{item.ParameterType}, {item.Name}, {item.Position}, {item.DefaultValue}, {item.IsOptional}  ");
            }

        }


        public static void DisplayInformation(string playerName, int score)
        {
            Console.WriteLine("Information about player : " + playerName + " score: " + score);
        }

        public static string DisplayInformation(int number, string club, string country = "Unknown")
        {
            Console.WriteLine("Hi");
            return string.Empty;
        }
    }
}