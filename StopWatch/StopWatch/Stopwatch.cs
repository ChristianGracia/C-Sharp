using System;

namespace StopWatch
{
    public class Stopwatch
    {
        public DateTime StartTime { get; set; }

        public Stopwatch(DateTime startTime)
        {
            StartTime = startTime;
        }


        public TimeSpan StopTimer
        {
            get
            {
                var timeSpan = DateTime.Now - StartTime;
                return timeSpan;
            }


        }



    }
}