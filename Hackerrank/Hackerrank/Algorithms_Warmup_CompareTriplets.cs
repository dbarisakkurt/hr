using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    static class Algorithms_Warmup_CompareTriplets
    {

        internal static void CompareAndPrintResult(int[] alicePoints, int[] bobPoints)
        {
            int alice = 0, bob = 0;
            if (alicePoints.Length != bobPoints.Length)
                throw new Exception("Array must have equal lengths");

            for(int i=0; i<alicePoints.Length; i++)
            {
                if (alicePoints[i] > bobPoints[i])
                    alice += 1;
                else if (bobPoints[i] > alicePoints[i])
                    bob += 1;
            }

            Console.WriteLine(alice + " " + bob);
        }
    }
}
