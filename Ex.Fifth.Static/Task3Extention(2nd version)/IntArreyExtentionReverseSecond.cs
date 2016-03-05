using System;

namespace Ex.Fifth.Static
{
    static partial class IntArreyExtentionSecond
    {
        public static void SortAscendingSecond(this int[] arr, bool direction)
        {
            Array.Sort(arr);
            if (!direction) Array.Reverse(arr);
        }
    }
}
