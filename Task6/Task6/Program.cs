using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            EvenSumArr(count, arr);
        }

        public static void EvenSumArr(int count, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    count ++;
                }
            }
            Console.WriteLine(count);
        }

    }
}
