using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            EvenSumArr(sum, arr);
        }

        public static void EvenSumArr(int sum, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }

    }
}
