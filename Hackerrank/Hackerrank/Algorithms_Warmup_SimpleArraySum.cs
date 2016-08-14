using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Algorithms_Warmup_SimpleArraySum
    {
        internal static int Sum(int[] array, int length)
        {
            if (length > array.Length)
                throw new Exception("Given number is larger than array length");

            int total = 0;
            for(int i=0; i<length; i++)
            {
                total += array[i];
            }
            return total;

        }
    }
}
