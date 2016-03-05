using System.Linq;


namespace Ex.Fifth.Static
{
    static partial class IntArreyExtention
    {
        public static void SortAscending(this int[] arr, bool direction)
        {
            if (direction)
            {
                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        i = -1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Count() - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        i = -1;
                    }
                }
            }
        }
    }
}
