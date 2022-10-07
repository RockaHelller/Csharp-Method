using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Division(28);
        }

        public static void Division(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("n 3-e ve 7-e bolunur");
            }
            else
            {
                Console.WriteLine("n 3 - e ve 7 - e bolunmur");
            }
        }

    }
}
