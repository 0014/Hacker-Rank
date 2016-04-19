using System;

namespace If_Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
