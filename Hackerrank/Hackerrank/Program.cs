using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32("6");
            string[] arr_temp = "1 2 3 4 10 11".Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int result = Algorithms_Warmup_SimpleArraySum.Sum(arr, n);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
