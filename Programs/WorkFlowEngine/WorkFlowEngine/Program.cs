using System;
using System.Collections.Generic;
using System.Net.Http;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.Add(new InstallProgram());
            workFlow.Run();

        }
    }

    public class WorkFlow
    {
        private readonly IList<IActivities> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivities>();
            
        }
        public void Add(IActivities activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }

    public interface IActivities
    {
        void Execute();
    }

    public class InstallProgram : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Installing program");
        }
    }
}
