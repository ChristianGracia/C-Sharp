namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.Add(new InstallProgram());
            workFlow.Add(new RunProgram());
            workFlow.Add(new LogInProgram());
            workFlow.Run();
        }
    }
}
