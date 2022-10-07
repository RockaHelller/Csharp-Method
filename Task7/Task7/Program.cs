using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeComplex(0, 13);
        }

        public static void PrimeComplex(int count, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("n is a prime number");
            }
            else if (n == 0 || n == 1)
            {
                Console.WriteLine("Please enter correct number");
            }
            else
            {
                Console.WriteLine("n is a complex number");
            }
        }

    }
}
