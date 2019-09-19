using System;

namespace WorkFlowEngine
{
    public class RunProgram : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Running program");
        }
    }
}