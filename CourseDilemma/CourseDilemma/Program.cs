using System;
using System.Collections.Generic;
using System.IO;

namespace CourseDilemma
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;
            int N = 0;
            int R = 0;

            T = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("T: {0}\n", T);

            for (int i = 0; i < T; i++)
            {
                N = Convert.ToInt32(Console.ReadLine());
                R = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("N: {0}, R: {1}\n", N, R);
                TestCase(i + 1, N, R);
            }
        }

        static void TestCase(int caseNumber, int N, int R)
        {
            int[] u = new int[499501]; 
            int[] v = new int[499501];
            int[] temp = new int[1001];
    
            int semesterCounter = 0; 
            int tempIndexCounter = 0;
    
            for(int i = 0; i < R; i++)
            {    
                u[i] = Convert.ToInt32(Console.ReadLine()); 
                v[i] = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("u: {0}, v: {1}\n", u[i], v[i]);
            }
        }
    }
}
