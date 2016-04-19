using System;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            // get the number of inputs
            int size = int.Parse(Console.ReadLine());

            // initialize D, this wont effect the overall time complexity
            int[] D = new int[size];
            for (int i = 0; i < size; i++)
            {
                D[i] = int.Parse(Console.ReadLine());
            }

            int[] endingList = new int[size]; // this array will store the ending elements of each active list
            endingList[0] = D[0];
            int len = 1;

            for (int i = 1; i < size; i++)
            {
                //If D[i] is smallest among all end candidates of active lists, we will start new active list of length 1.
                if (D[i] < endingList[0])
                    endingList[0] = D[i];
                //If D[i] is largest among all end candidates of active lists, we will clone the largest active list, 
                //and extend it by D[i].
                else if (D[i] > endingList[len - 1])
                {
                    endingList[len] = D[i];
                    len++;
                }
                //If D[i] is in between, we will find a list with largest end element that is smaller than D[i]. Clone and extend 
                // this list by D[i]. We will discard all other lists of same length as that of this modified list.
                else
                {
                    var position = FindPosition(endingList, D[i], -1, len - 1);
                    endingList[position] = D[i];
                }
            }

            Console.WriteLine(len);
        }

        static int FindPosition(int[] endingList, int key, int l, int r)
        {
            while (r - l > 1)
            {
                int m = l + (r - l) / 2;

                if (endingList[m] >= key)
                    r = m;
                else
                    l = m;
            }

            return r;
        }
    }
}
