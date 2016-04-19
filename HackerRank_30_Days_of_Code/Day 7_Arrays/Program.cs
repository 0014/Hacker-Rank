using System;

namespace Day_7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for(int i = n-1; i>=0; i-- )
                Console.Write(arr[i] + " ");
        }
    }
}
