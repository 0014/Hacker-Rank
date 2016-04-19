using System;

namespace D_Sherlock_and_The_Beast
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                TellSherlock(n);
            }
        }

        static void TellSherlock(int n)
        {
            if (n % 3 == 0)
            {
                for (int i = 0; i < n; i++)
                    Console.Write("5");
            }
            else if ((n - 5) % 3 == 0 && (n - 5) >= 0)
            {
                for (int i = 0; i < n - 5; i++)
                    Console.Write("5");
                for (int i = n - 5; i < n; i++)
                    Console.Write("3");
            }
            else if ((n - 10) % 3 == 0 && (n - 10) >= 0)
            {
                for (int i = 0; i < n - 10; i++)
                    Console.Write("5");
                for (int i = n - 10; i < n; i++)
                    Console.Write("3");
            }
            else
            {
                Console.Write("-1");
            }

            Console.WriteLine("");

        }
    }
}
