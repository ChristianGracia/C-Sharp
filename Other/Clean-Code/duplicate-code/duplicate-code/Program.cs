using System;

namespace duplicate_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //DRY principle - do not repeat yourself
            //highlight repeated code, extract method with resharp



        }
    }

    //before refactor
    class DuplicateCode
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            //logic

            int time;
            int hours = 0;
            int minutes = 0;

            if (!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if (int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
            }
            else
            {
                throw new ArgumentException("AdmissionDateTime");
            }
        }
    }

    class DuplicateCodeRefactored
    {

    }
}
