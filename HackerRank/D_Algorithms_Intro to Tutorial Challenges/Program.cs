using System;

namespace D_Algorithms_Intro_to_Tutorial_Challenges
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var key = Int32.Parse(Console.ReadLine());
            var n = Int32.Parse(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            
            Console.WriteLine(BinarySearch(arr, n, key)); 
        }

        static int BinarySearch(int[] arr, int size, int key)
        {
            var r = size - 1;
            var l = 0;

            while (l <= r)
            {
                var m = l + (r - l) / 2;

                if (arr[m] == key)
                    return m;

                if (arr[m] > key)
                    r = m - 1;
                else
                    l = m + 1;
            }

            return -1;
        }
    }
}
