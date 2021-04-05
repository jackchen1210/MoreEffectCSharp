using System;

namespace Item21
{
    
    public class WorkEventArgs : EventArgs
    {
        public int Percent { get; set; }
        public bool Cancel { get; private set; }
    }

}