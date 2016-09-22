using System;

namespace Hackerrank
{
    static class Algorithms_Warmup_Kangoroo
    {
        //Hackerrank
        //Algorithms / Warmup / Kangoroo Question
        public static void Kangoroo()
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            bool samePlace = false;

            if (x2 > x1 && v2 > v1)
            {
                Console.WriteLine("NO");
                return;
            }
            else
            {
                if (x1 < x2)
                {
                    while (x1 <= x2 || samePlace == true)
                    {
                        x1 += v1;
                        x2 += v2;
                        if (x1 == x2)
                        {
                            samePlace = true;
                            break;
                        }
                        if (x1 > x2)
                            break;
                    }
                }
                else
                { //x1>=x2
                    while (x1 >= x2 || samePlace == true)
                    {
                        x1 += v1;
                        x2 += v2;
                        if (x1 == x2)
                        {
                            samePlace = true;
                            break;
                        }
                        if (x1 < x2)
                            break;
                    }
                }
            }

            if (samePlace)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
