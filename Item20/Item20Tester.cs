using System;

namespace Item20
{
    public static class Test
    {
        public static void Run()
        {
            var worker = new WorkerEngine();
            worker.OnProgress += (_, __) => Rcv(_, __, 1);
            worker.OnProgress += (_, __) => Rcv(_, __, 2);
            worker.DoLotsOfStuff();
        }

        private static void Rcv(object sender, WorkEventArgs workEventArgs, int number)
        {
            System.Console.WriteLine($"Rcv {number} : {workEventArgs.Percent}");
            if (number == 1)
            {
                //workEventArgs.Cancel = true;
            }
        }
    }
}