using System;

namespace duplicate_code
{
    class DuplicateCodeRefactored
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

        public void UpdateAdmission(string name, string admissionDateTime)
        {
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
}