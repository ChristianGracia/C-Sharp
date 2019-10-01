using System;

public class Time
{


        public int Hours { get; set; }
        public int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public static Time GetTime(string admissionDateTime)
        {
            //logic

            int time;
            var hours = 0;
            var minutes = 0;

            if (!String.IsNullOrWhiteSpace(admissionDateTime))
            {
                if (Int32.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
            }
            else
                throw new ArgumentException("AdmissionDateTime");

            return new Time(hours, minutes);
        
    }
}