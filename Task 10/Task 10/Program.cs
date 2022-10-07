using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            int square = 0;
            EvenSquare(arr, sum, square);
        }

        public static void EvenSquare(int[] arr, int sum, int square)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            square = sum * sum;
            Console.WriteLine(square);
        }

    }
}
