using System;

namespace NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
      
            DisplayPersonInfo(club:"football", age: 7, name:"jack");
        }

        public static void DisplayPersonInfo(string name, int age, string club)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(club);
        }
    }
}
