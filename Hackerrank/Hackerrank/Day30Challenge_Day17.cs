using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day17MoreException
    {
        class Calculator
        {
            public int power(int a, int b)
            {
                if (a < 0 || b < 0)
                    throw new ArgumentException("n and p should be non-negative");

                return (int)Math.Pow(a, b);

            }
        }
    }
}
