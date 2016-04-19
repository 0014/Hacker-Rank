using System;

namespace E_Time_Conversion
{
    class Program
    {
        static void Main(String[] args)
        {
            string time = Console.ReadLine();

            if (time.Contains("PM"))
            {
                if (time.Split('P', 'M', ':')[0].Equals("12"))
                    time = "12" + time.Substring(2, 6);
                else
                    time = (Int32.Parse(time.Substring(0, 2)) + 12) + time.Substring(2, 6);
            }
            else
            {
                if (time.Split('A', 'M', ':')[0].Equals("12"))
                    time = "00" + time.Substring(2, 6);
                else
                    time = time.Split('A', 'M')[0];
            }

            Console.WriteLine(time);
        }
    }
}
