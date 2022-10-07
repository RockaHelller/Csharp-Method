using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            SquareEqual(0);

        }

        public static void SquareEqual(int n)
        {

            int i = 2;

            if (n < 1)
            {
                Console.WriteLine("Zehmet olmasa duzgun eded daxil edin");
            }
            else
            {
                while (i < n)
                {
                    
                        i *= 2;
                }

            if (n == i)
            {
                Console.WriteLine("Beraberdir");
            }
            else
            {
                Console.WriteLine("Beraber deyil");
            }
                
            }

        }


    }
}
