using System;

namespace ConsecutiveSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            var consecutiveFlag = true;
            Console.WriteLine("Input consecutive numbers seperated by a hyphen");
            var input = Console.ReadLine();
            Console.WriteLine(input);
            var numberArray = input.Split("-");

            foreach (var x in numberArray)
                Console.WriteLine(x);



            for (var i = 0; i < numberArray.Length -1; i++)
                if (Convert.ToInt32(numberArray[i]) != (Convert.ToInt32(numberArray[i + 1]) - 1))
                    consecutiveFlag = false;

            if (consecutiveFlag)
                Console.WriteLine("Consecutive!");
            else
                Console.WriteLine("Not Consecutive");
        }
    }
}
