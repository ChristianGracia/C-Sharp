using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.Count(4);
            worker.Count(5);

            worker.Count(4.5f);
         
        }
        public class Worker
        {
            public Worker() {

            }
            public void Count (int number)
            {
                if (Total == null)
                    Total = 0;
                Total = Total + Convert.ToSingle(number);
                Console.WriteLine(Total.ToString());
            }

            public void Count(float number)
            {
                Total = Total + number;
                Console.WriteLine(Total.ToString());
            }

            public float Total { get; set; }

        }
    }
}
