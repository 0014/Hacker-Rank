using System;

namespace Day_5_Loops
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i ++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

                var a = arr[0];
                var b = arr[1];
                var N = arr[2];

                for (int j = 0; j < N; j ++)
                {
                    var term = a;

                    for (int k = 0; k <= j; k ++)
                    {
                        term += (int) (b * Math.Pow(2, k));
                    }

                    Console.Write(term);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
