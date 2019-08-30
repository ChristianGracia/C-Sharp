using System;

namespace CheckUserDateFormat
{
    class Program
    {
        static void Main(string[] args)
        {     
            var validFlag = true;
            Console.WriteLine("Enter date between 00:00 to 23:59");
            var input = Console.ReadLine();
            var dateInput = input.Split(":");

            if (dateInput.Length != 2 || dateInput[1].Length != 2 || dateInput[0].Length != 2)
                validFlag = false;

            if (validFlag)
            {
                for (int i = 0; i <= 1; i++)
                {
                    for (int j = 0; j <= 1; j++)
                    {
                        if (Char.IsLetter(dateInput[i][j]))
                            validFlag = false;
                    }
                }
                if (validFlag)
                {
                    var hours = Convert.ToInt32(dateInput[0]);
                    var minutes = Convert.ToInt32(dateInput[1]);

                    if (hours > 23 || hours < 0 || minutes < 0 || minutes > 59)
                    {
                        validFlag = false;
                    }
                }
            }
            if (validFlag)
            {
                Console.WriteLine("correct time format");
             
            }
            else
                Console.WriteLine("incorrect time format");
        }
    }
}
