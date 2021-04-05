using System;

namespace Item22
{
    public class Utilities
    {
        public static double Max(float left,float right)
        {
            return Math.Max(left,right);
        }

        public static T Max<T>(T left,T right) where T : IComparable<T>
        {
            return left.CompareTo(right) >0?left:right;
        }
    }
}