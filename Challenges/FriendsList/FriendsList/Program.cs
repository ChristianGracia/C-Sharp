using System;

namespace FriendsList
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter as name: ");
                var name = Console.ReadLine();
                Console.WriteLine("name : {0}", name);

                if (name == "")
                    break;
            }
        }
    }
}
