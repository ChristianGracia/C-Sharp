using System;

namespace PascalCaser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to be converted to Pascale Case");
            var inputString = Console.ReadLine().ToLower();
            var stringArray = inputString.Split(" ");

            for (var i = 0; i < stringArray.Length; i++)
            {
              stringArray[i] =   stringArray[i].Substring(0, 1).ToUpper() + stringArray[i].Substring(1);
            }
            var pascaleCaseString = "";
            foreach (var item in stringArray)
            {
                pascaleCaseString += item;
            }
            Console.WriteLine(pascaleCaseString);
        }
    }
}
