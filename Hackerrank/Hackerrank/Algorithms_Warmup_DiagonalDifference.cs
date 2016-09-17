using System;


namespace Hackerrank
{
    //Hackerrank
    //Algorithms / Warmup / Diagonal Difference
    static class Algorithms_Warmup_DiagonalDifference
    {
        static int DiagonalDifference(int n)
        {
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            int diag1 = 0, diag2 = 0;
            for (int i = 0; i < n; i++)
            {
                diag1 += a[i][i];
            }

            int j = n - 1;
            for (int i = 0; i < n; i++)
            {
                diag2 += a[i][j];
                j -= 1;
            }

            return Math.Abs(diag1 - diag2);
        }

    }
}
