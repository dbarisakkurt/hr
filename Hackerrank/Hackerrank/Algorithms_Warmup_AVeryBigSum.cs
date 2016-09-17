using System;

namespace Hackerrank
{
    //Hackerrank
    //Algorithms / Warmup / A Very Big Sum Question
    static class Algorithms_Warmup_AVeryBigSum
    {
        internal static long AVeryBigSum(int n)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            long total = 0;

            for (int i = 0; i < n; i++)
            {
                total += (long)arr[i];
            }
            return total;
        }

    }
}
