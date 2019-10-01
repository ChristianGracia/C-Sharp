using System;

namespace duplicate_code
{
    class DuplicateCodeRefactored
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            int hours;
            int minutes;
            GetTime(admissionDateTime, out hours, out  minutes);
        }

        public void GetTime(string admissionDateTime, out int hours, out int minutes)
        {
            //logic

            int time;
            hours = 0;
            minutes = 0;

            if (!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if (int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
            }
            else
                throw new ArgumentException("AdmissionDateTime");
        }

        public void UpdateAdmission(string name, string admissionDateTime)
        {
            int hours;
            int minutes;
            GetTime(admissionDateTime, out hours, out minutes);
        }
    }
}