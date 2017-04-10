using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    static class Day11MultiDimArray
    {
        public static void Execute()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            List<int> totals = new List<int>();

            for (int i = 1; i < arr.Length - 1; i++)
            {
                for (int j = 1; j < arr.Length - 1; j++)
                {
                    totals.Add(CalculateTotal(i, j, arr));
                }
            }


            int largest = totals[0];
            foreach (int total in totals)
            {
                if (total > largest)
                    largest = total;
            }

            Console.WriteLine(largest);
        }


        static int CalculateTotal(int centerX, int centerY, int[][] array)
        {
            int total = array[centerX - 1][centerY - 1] + array[centerX - 1][centerY] + array[centerX - 1][centerY + 1] +
                array[centerX][centerY] +
                array[centerX + 1][centerY - 1] + array[centerX + 1][centerY] + array[centerX + 1][centerY + 1];

            return total;
        }

    }
}
