using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            //Console.WriteLine(random.Next(1,10));

            const int passwordLength = 10;

            var buffer = new char[passwordLength];
            for (var x = 0; x < passwordLength; x++)
            {

                buffer[x] = (char)('a' + random.Next(0, 26));
            }

                var password = new string(buffer);
                Console.WriteLine(password);
        }
    }
}
