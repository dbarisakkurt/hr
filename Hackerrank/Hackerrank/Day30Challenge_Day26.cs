using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day26NestedLogic
    {
        static void Execute()
        {
            string line1 = Console.ReadLine();
            MyDate returnDate = new MyDate();
            returnDate.day = int.Parse(line1.Split(' ')[0]);
            returnDate.month = int.Parse(line1.Split(' ')[1]);
            returnDate.year = int.Parse(line1.Split(' ')[2]);

            string line2 = Console.ReadLine();
            MyDate lastDate = new MyDate();
            lastDate.day = int.Parse(line2.Split(' ')[0]);
            lastDate.month = int.Parse(line2.Split(' ')[1]);
            lastDate.year = int.Parse(line2.Split(' ')[2]);

            if (returnDate.year > lastDate.year)
                Console.WriteLine(10000);
            else if (returnDate.month > lastDate.month)
            {
                Console.WriteLine(500 * (returnDate.month - lastDate.month));
            }
            else if (returnDate.day > lastDate.day)
            {
                Console.WriteLine(15 * (returnDate.day - lastDate.day));
            }
        }

    }

    class MyDate
    {
        public int day;
        public int month;
        public int year;
    }
}
