using System;

namespace Item21
{
    public class Tester
    {
        public static void Run()
        {
            WorkerEngineBase workerEngine = new WorkerEngineDerived();
            workerEngine.OnProgress += OnEventProgrssRcv;
            workerEngine.DoLotsOfStuff();
        }

        private static void OnEventProgrssRcv(object sender, WorkEventArgs e)
        {
            System.Console.WriteLine($"OnEventProgrssRcv : {e.Percent}");
        }
    }
}