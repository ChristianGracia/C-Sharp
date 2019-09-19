using System.Collections.Generic;

namespace WorkFlowEngine
{
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
}