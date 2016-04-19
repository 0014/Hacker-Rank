using System;

namespace Day_2_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int T, X;
            double M;
            M = Convert.ToDouble(Console.ReadLine());
            T = Int32.Parse(Console.ReadLine());
            X = Int32.Parse(Console.ReadLine());

            double tip = M * T / 100;
            double tax = M * X / 100;
            int sum = (int)Math.Round(tax + tip + M);

            Console.WriteLine("The final price of the meal is $" + sum + ".");
        }
    }
}
