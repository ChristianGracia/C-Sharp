using System;

namespace CheckUserDateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int intCheck;
            var validFlag = true;
            Console.WriteLine("Enter date between 00:00 to 23:59");
            var dateInput = Console.ReadLine();

            if (Int32.TryParse(dateInput, out intCheck) || dateInput.Length > 5 || dateInput == "") 
                Console.WriteLine("incorrect");

            validFlag = false;

            if (validFlag)
            {
           
                var letterArray = dateInput.Split(':');
                var hours = letterArray[0];
                var minutes = letterArray[1];


            }
        }
    }
}
