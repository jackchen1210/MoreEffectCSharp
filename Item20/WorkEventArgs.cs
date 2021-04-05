using System;

namespace Item20
{

    public class WorkEventArgs : EventArgs
    {
        public int Percent { get; set; }
        public bool Cancel { get; private set; }

        // public void RequestCancel()
        // {
        //     Cancel = true;
        // }
    }
}