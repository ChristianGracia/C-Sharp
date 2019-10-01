using System;

namespace duplicate_code
{
    public class Time
    {
        public int Item1 { get; set; }
        public int Item2 { get; set; }

        public Time(int item1, int item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
    class DuplicateCodeRefactored
    {
        public void AdmitGuest(string name, string admissionDateTime)
        {
            var tuple = GetTime(admissionDateTime);
            var hours = tuple.Item1;
            var minutes = tuple.Item2;
        }

        public Tuple<int, int> GetTime(string admissionDateTime)
        {
            //logic

            int time;
            var hours = 0;
            var minutes = 0;

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

            return Tuple.Create(hours, minutes);
        }

        public void UpdateAdmission(string name, string admissionDateTime)
        {
            var tuple = GetTime(admissionDateTime);
            var hours = tuple.Item1;
            var minutes = tuple.Item2;
        }
    }
}