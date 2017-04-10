using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day8Dictionary
    {
        public static void Execute()
        {
            int entryNumber = int.Parse(Console.ReadLine());
            Dictionary<string, string> phones = new Dictionary<string, string>();
            for (int i = 0; i < entryNumber; i++)
            {
                string line = Console.ReadLine();
                string name = line.Split(' ')[0];
                string phone = line.Split(' ')[1];
                phones[name] = phone;
            }

            for (int i = 0; i < entryNumber; i++)
            {
                string name = Console.ReadLine();
                if (phones.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + phones[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
