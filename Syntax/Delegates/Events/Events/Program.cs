using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void messageDelegate(string name);

    class Program
    {
        public event messageDelegate messageEvent;

        public Program()
        {
            messageEvent += new messageDelegate(SayHiEnglish);
            messageEvent += new messageDelegate(SayHiSpanish);
            messageEvent += new messageDelegate(SayHiItalian);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.messageEvent("chris");
        }

        public void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi " + name);
        }


        public void SayHiSpanish(string name)
        {
            Console.WriteLine("Hola " + name);
        }

        public void SayHiItalian(string name)
        {
            Console.WriteLine("Caio " + name);
        }
    }
}