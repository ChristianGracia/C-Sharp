using System;

namespace Strings01
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var firstName = "Hugo";
       
            var lastName = "Oguh";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("\n" + fullName);

            var names = new string[3] { "john", "joe", "josh" };

            var namesFormatted = string.Join(",", names);
            Console.WriteLine(namesFormatted);

            var text = "Hello User \nTry Checking Here\nc:\\folders1\\folder2\\data\\src\\bin";
            var text1 = @"Hello User 
Try Checking Here
c:\folders1\folder2\data\src\bin";

            Console.WriteLine(text);
            Console.WriteLine(text1);


        }
    }
}
