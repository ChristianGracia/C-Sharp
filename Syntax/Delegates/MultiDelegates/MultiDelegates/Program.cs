using System;


namespace MultiDelegate
{
    public delegate void SayHiDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            SayHiDelegate sayHi = null;

            sayHi = new SayHiDelegate(SayHiEnglish);
            sayHi += new SayHiDelegate(SayHiSpanish);
            sayHi += new SayHiDelegate(SayHiJapanese);
            sayHi += new SayHiDelegate(SayHiItalian);
            sayHi += new SayHiDelegate(SayHiGerman); 
            sayHi += new SayHiDelegate(SayHiArabic);
            sayHi();

        }

        public static void SayHiEnglish()
        {
            Console.WriteLine("Hi there.");
        }

        public static void SayHiSpanish()
        {
            Console.WriteLine("Hola.");
        }

        public static void SayHiItalian()
        {
            Console.WriteLine("Ciao.");
        }

        public static void SayHiGerman()
        {
            Console.WriteLine("Hallo.");
        }

        public static void SayHiArabic()
        {
            Console.WriteLine("Marhabaan.");
        }

        public static void SayHiJapanese()
        {
            Console.WriteLine("Kon'nichiwa");
        }
    }
}