using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day21Generics
    {
        static void PrintArray<T>(T[] input)
        {
            foreach (T item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
