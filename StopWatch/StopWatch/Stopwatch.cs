using System;
using System.Threading;

namespace StopWatch
{
    public class Stopwatch
    {
        
        public DateTime StopTime { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan AddedTime { get; set; }

        public void Start()
        {
            StartTime = DateTime.Now + AddedTime;
            

        }
        public void Stop()
        {
            StopTime = DateTime.Now + AddedTime; 

        }



        public TimeSpan StopTimer
        {
            get
            {
                var timeSpan = StopTime - StartTime;
                return timeSpan;
            }

        }
    }
}