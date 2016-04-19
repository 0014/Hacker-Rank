using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Diagonal_Difference
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum1 += a[i][i];
                sum2 += a[i][n - 1 - i];
            }
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
