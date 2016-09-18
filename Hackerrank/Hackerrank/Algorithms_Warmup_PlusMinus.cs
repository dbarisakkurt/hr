using System;

namespace Hackerrank
{
    //Hackerrank
    //Algorithms / Warmup / Plus Minus
    static class Algorithms_Warmup_PlusMinus
    {
        public static void PlusMinus(int n)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int zero = 0, pos = 0, neg = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    pos += 1;
                }
                else if (arr[i] == 0)
                {
                    zero += 1;
                }
                else
                {
                    neg += 1;
                }
            }
            Console.WriteLine((double)pos / n);
            Console.WriteLine((double)neg / n);
            Console.WriteLine((double)zero / n);
        }
    }
}
