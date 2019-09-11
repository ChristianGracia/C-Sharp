using System;

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
            StartCheck = true;
            StartTime = DateTime.Now + AddedTime;
            Console.WriteLine("\nTimer Started");
        }
        public void Stop()
        {
            StartCheck = false;
            StopTime = DateTime.Now + AddedTime;
            Console.WriteLine("\nTimer Stopped");
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