using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day12Inheritance
    {
        class Student// : Person
        {
            private int[] testScores;

            public Student(string firstName, string lastName, int identification, int[] scores)
            // : base(firstName, lastName, identification)
            {
                this.testScores = scores;

            }

            public char calculate()
            {
                int total = 0;
                foreach (int score in testScores)
                {
                    total += score;
                }

                int average = total / testScores.Length;

                if (average <= 100 && average >= 90)
                    return 'O';
                else if (average < 90 && average >= 80)
                    return 'E';
                else if (average < 80 && average >= 70)
                    return 'A';
                else if (average < 70 && average >= 55)
                    return 'P';
                else if (average < 55 && average >= 40)
                    return 'D';
                else if (average < 40)
                    return 'T';
                return ' ';

            }

        }
    }
}
