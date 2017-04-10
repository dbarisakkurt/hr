using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day9Recursion
    {
        public static int factorial(int number)
        {
            if (number == 1)
                return 1;
            else
                return factorial(number - 1) * number;
        }
    }
}
