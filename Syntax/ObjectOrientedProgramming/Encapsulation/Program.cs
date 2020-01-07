using System;

namespace Encapsulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            var worker = new Worker();
            var result = worker.AddNumbers(2, 3);
            Console.WriteLine(result.ToString());


        }
    }

    public class Worker
    {
        public Worker(){

        }

         public int AddNumbers (int num1, int num2) {
                var result = num1 + num2;
                return result;
         } 
        
    }
}
