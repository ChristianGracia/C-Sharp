using System;

namespace WorkFlowEngine
{
    public class InstallProgram : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Installing program");
        }
    }
}