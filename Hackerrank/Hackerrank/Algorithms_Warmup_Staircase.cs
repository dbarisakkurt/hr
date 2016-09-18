using System;

namespace Hackerrank
{
    static class Algorithms_Warmup_Staircase
    {
        //Hackerrank
        //Algorithms / Warmup / Staircase
        public static void Staircase(int n)
        {
            int k = n - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= k)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                k -= 1;
                Console.WriteLine();
            }
        }
    }
}
