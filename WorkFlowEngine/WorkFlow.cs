using System;
using System.Collections.Generic;

namespace WorkFlowEngine
{
    public class WorkFlow
    {
        private readonly string _name;
        private readonly IList<IActivity> _activities;

        public WorkFlow(string name, IList<IActivity> activities)
        {
            if(activities == null || activities.Count == 0)
                throw new InvalidOperationException("A list of activities must be supplied for this workflow.");

            _activities = activities;
            _name = name;
        }

        public void RunAll()
        {
            Console.WriteLine("Starting workflow: {0}", _name);
            foreach (var activity in _activities)
            {
                activity.Run();
            }
            Console.WriteLine("Workflow completed: {0}", _name);
        }
    }
}
