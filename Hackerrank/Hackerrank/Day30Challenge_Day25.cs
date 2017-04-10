using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day25RunningTime
    {
        public static bool IsPrime(int number)
        {
            if (number == 1)
                return false;
            if (number == 2)
                return true;

            int i = 1;
            do
            {
                i += 1;
                if (number % i == 0)
                    return false;
            } while (i < Math.Round(Math.Sqrt(number)));
            return true;
        }
    }
}
