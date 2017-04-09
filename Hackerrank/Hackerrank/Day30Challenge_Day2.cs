using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class Day2Operators
    {
        public static void Execute()
        {
            double cost = 10.25;
            int tipPercent = 17;
            int taxPercent = 5;

            double tip = (cost * tipPercent) / 100;
            double tax = (cost * taxPercent) / 100;

            double totalCost = cost + tip + tax;

            Console.WriteLine(Math.Round(totalCost));
            Console.ReadLine();
        }


    }
}
