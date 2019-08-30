using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "dog bountyhunter ";
            Console.WriteLine("Trim: '{0}' ", name.Trim());
            Console.WriteLine("ToUpper: '{0}' ", name.ToUpper());

            var index = name.IndexOf(" ");
            var firstName = name.Substring(0, index);
            var lastName = name.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = name.Split(" ");
            Console.WriteLine("arr: " + names[0]);
            Console.WriteLine("arr: " + names[1]);

            var replaced = name.Replace("dog", "Jobe");
            Console.WriteLine(replaced);

            var empty = " ";

            if (String.IsNullOrEmpty(empty))
                Console.WriteLine("err");

            if(String.IsNullOrWhiteSpace(empty))
                Console.WriteLine("empty");

            var str = "20";

            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 19.99f;
            Console.WriteLine(price.ToString("C"));

        }
    }
}
