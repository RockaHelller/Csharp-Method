using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenSum(6, 8);
        }

        public static void EvenSum(int n, int m)
        {
            if (n % 2 == 0 && m % 2 == 0)
            {
                Console.WriteLine(m + n);
            }
            else
            {
                Console.WriteLine("Duzgun reqem daxil edin");
            }
        }

    }
}
