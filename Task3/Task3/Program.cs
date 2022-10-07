using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            EvenCount(0, 3, 9);
        }

        public static void EvenCount(int count, int n, int m)
        {
            for (int i = n; i < m; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

    }
}
