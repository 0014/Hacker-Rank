using System;

namespace E_Plus_Minus
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            float posCounter = 0;
            float negCounter = 0;
            float zeroCounter = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    posCounter++;
                }
                else if (arr[i] < 0)
                {
                    negCounter++;
                }
                else
                {
                    zeroCounter++;
                }
            }

            Console.WriteLine(posCounter / n);
            Console.WriteLine(negCounter / n);
            Console.WriteLine(zeroCounter / n);
        }
    }
}
