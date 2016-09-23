using System;

namespace Hackerrank
{
    static class Algorithms_Warmup_AngryProfessor
    {
        //Hackerrank
        //Algorithms / Warmup / Angry Professor Question
        public static void AngryProfessor()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]); //students
                int k = Convert.ToInt32(tokens_n[1]); //threshold
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse); //arrival dates

                int onTime = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] <= 0)
                        onTime += 1;
                }
                if (onTime < k)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
        }
    }
}
