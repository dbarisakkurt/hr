using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    //Hackerrank
    //Algorithms / Warmup / Divisible Sum Pairs Question
    static class Algorithms_Warmup_DivisibleSumPairs
    {
        public static void DivisibleSumPairs()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int counter = 0;
            int m = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = m; j < n; j++)
                {
                    if ((a[i] + a[j]) % k == 0)
                        counter += 1;
                }
                m += 1;
            }

            Console.WriteLine(counter);
        }
    }
}
