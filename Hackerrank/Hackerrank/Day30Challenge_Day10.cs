using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day10Binary
    {
        public static void Execute(int number)
        {
            string a = ConvertToBinary(number);
            int b = CountConsecutiveOnes(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }

        public static int CountConsecutiveOnes(string text)
        {
            int result = 0;
            int tempResult = 0;

            for (int i = 0; i < text.Length; i++)
            {
                tempResult = 0;
                int j = i;
                while (j < text.Length && text[j] == '1')
                {
                    tempResult += 1;
                    j += 1;
                }

                if (tempResult > result)
                    result = tempResult;
            }

            return result;
        }

        public static string ConvertToBinary(int number)
        {
            string result = "";

            while (number > 0)
            {
                result = (number % 2).ToString() + result;
                number = number / 2;
            }
            return result;
        }
    }
}
