using System;

namespace Day_6_Let_s_Review
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                    Console.Write(" ");
                for (int j = i; j > 0; j--)
                    Console.Write("#");
                Console.WriteLine("");
            }
        }
    }
}
