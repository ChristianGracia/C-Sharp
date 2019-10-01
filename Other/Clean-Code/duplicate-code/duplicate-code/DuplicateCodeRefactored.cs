using System;

namespace duplicate_code
{
 
    class DuplicateCodeRefactored
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            var time = Time.GetTime(admissionDateTime);
        
            

            //logic
            if (time.Hours < 10)
                Console.WriteLine("less");
        }

        public void UpdateAdmission(string name, string admissionDateTime)
        {
            var time = Time.GetTime(admissionDateTime);

            //logic
            if (time.Hours < 10)
                Console.WriteLine("less");
        }
    }
}