using System;

namespace magic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MagicNumbers
    {
        public void ApproveDocument(int status)
        {

            //these numbers are "magic numbers" reader does not know what these numbers mean
            if (status == 1)
                Console.WriteLine("do something");
            else if (status == 2)
                Console.WriteLine("do something else");
        }
        
    }
}
