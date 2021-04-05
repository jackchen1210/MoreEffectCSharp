

using System;
using System.Threading;

namespace Item21
{
    public class WorkerEngineDerived : WorkerEngineBase
    {

        // public override event EventHandler<WorkEventArgs> OnProgress
        // {
        //     add { progressEvent += value; }
        //     remove { progressEvent -= value; }
        // }

        public override event EventHandler<WorkEventArgs> OnProgress;

        public override void DoWork()
        {
            Thread.Sleep(50);
        }

        protected override void RaisedEvent(WorkEventArgs args){
            OnProgress?.Invoke(this,args);
        }
    }
}