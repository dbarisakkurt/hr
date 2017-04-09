using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class Day1DataTypes
    {
        internal void Execute()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int integer = int.Parse(Console.ReadLine());
            double doubleVar = double.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            Console.WriteLine(i + integer);
            Console.WriteLine(String.Format("{0:0.0}", d + doubleVar));
            Console.WriteLine(s + text);
        }

    }
}
