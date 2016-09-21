using System;

namespace Hackerrank
{
    //Hackerrank
    //Algorithms / Warmup / Circular Array Rotation
    static class Algorithms_Warmup_CircularArrayRotation
    {
        static void CircularArrayRotation()
        {
            int n = -1, k = -1, q = -1;
            string line1 = Console.ReadLine();
            string[] ln1 = line1.Split(' ');
            n = Convert.ToInt32(ln1[0]);
            k = Convert.ToInt32(ln1[1]);
            q = Convert.ToInt32(ln1[2]);

            int[] array = new int[n];
            int[] newArray = new int[n];
            int[] queries = new int[q];

            string line2 = Console.ReadLine();
            string[] ln2 = line2.Split(' ');

            for (int i = 0; i < q; i++)
            {
                queries[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(ln2[i]);
            }
            int index = -1;


            for (int j = array.Length - 1; j >= 0; j--)
            {
                int newIndex = (j + k) % array.Length;
                newArray[newIndex] = array[j];
            }

            //print result
            for (int i = 0; i < queries.Length; i++)
            {
                Console.WriteLine(newArray[queries[i]]);
            }
        }
    }
}
