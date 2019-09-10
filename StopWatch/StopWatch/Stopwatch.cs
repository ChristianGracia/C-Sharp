using System;
using System.IO;
using System.Threading;

namespace StopWatch
{
    public class Stopwatch
    {
        public DateTime StopTime { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan AddedTime { get; set; }
        public bool StartCheck;

        public void Start()
        {
            if (StartCheck)
                throw new InvalidOperationException();
            else
            {
                StartCheck = true;
                StartTime = DateTime.Now + AddedTime;
            }
        }
        public void Stop()
        {
            StartCheck = false;
            StopTime = DateTime.Now + AddedTime;
        }

        public void AddTime(TimeSpan addedTime)
        {
            AddedTime = addedTime;
        }

        public TimeSpan StopTimer
        {
            get
            {
                var timeSpan = StopTime - StartTime + AddedTime;
                return timeSpan;
            }
        }
    }
}