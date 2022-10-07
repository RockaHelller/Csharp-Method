using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 34, 6, 4, 234, 53, 79, 25, 12, 23, 19 };
            int multi = 1;
            RangeMulti(arr, multi);

        }

        public static void RangeMulti(int[] arr, int multi)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 1 && arr[i] <= 20)
                {
                    multi *= arr[i];
                }
            }
            Console.WriteLine(multi);
        }

    }
}
