using System;

namespace Item21
{

    public abstract class WorkerEngineBase
    {
        //complier create private backing field
        public virtual event EventHandler<WorkEventArgs> OnProgress;

        protected virtual void RaisedEvent(WorkEventArgs args)
        {
            OnProgress?.Invoke(this, args);
        }

        public void DoLotsOfStuff()
        {
            for (var i = 0; i < 100; i++)
            {
                DoWork();
                var args = new WorkEventArgs();
                args.Percent = i;
                RaisedEvent(args);
                if (args.Cancel)
                {
                    return;
                }
            }
        }

        public abstract void DoWork();
    }
}