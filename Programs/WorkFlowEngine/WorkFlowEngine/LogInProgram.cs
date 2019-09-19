using System;

namespace WorkFlowEngine
{
    public class LogInProgram : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Logging into program");
        }
    }
}