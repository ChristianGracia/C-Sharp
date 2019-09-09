using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace methods01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            var result = int.TryParse("adc", out number);
            if(result)
                Console.WriteLine(number);
            else
            {
                Console.WriteLine("conversion failed");
            }

        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            calculator.Add(1, 2);
            calculator.Add(1, 2);
            calculator.Add(1, 2, 3, 5, 6);
            calculator.Add(1, 2);
            Console.WriteLine(
                calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(40, 60);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("error occured");
            }
        }
    }
}
