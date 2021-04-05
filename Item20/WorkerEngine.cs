using System;

namespace Item20
{
    public class WorkerEngine
    {
        public event EventHandler<WorkEventArgs> OnProgress;

        public void DoLotsOfStuff()
        {
            var args = new WorkEventArgs();
            for (var i = 0; i < 100; i++)
            {
                //Some work
                args.Percent = i;
                OnProgress?.Invoke(this, args);
                if (args.Cancel)
                {
                    return;
                }
            }
        }
    }
}