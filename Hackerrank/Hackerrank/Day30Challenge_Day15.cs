using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day6LetsReview
    {
        public static void Execute()
        {
            int testCases = int.Parse(Console.ReadLine());
            List<string> strings = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                strings.Add(Console.ReadLine());
            }



            foreach (string text in strings)
            {
                string evenStr = "";
                string oddStr = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (i % 2 == 0)
                        evenStr += text[i];
                    else
                        oddStr += text[i];
                }

                Console.Write(evenStr);
                Console.Write(" ");
                Console.WriteLine(oddStr);
            }
        }
    }
}
