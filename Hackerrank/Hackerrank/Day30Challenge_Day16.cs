using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day16Exceptions
    {
        public static void Execute()
        {
            try
            {
                string S = Console.ReadLine();
                Console.WriteLine(int.Parse(S));
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Bad String");
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
