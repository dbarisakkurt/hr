using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Day18Stack
    {
        class Solution
        {
            Stack<char> stack;
            Queue<char> queue;

            public Solution()
            {
                stack = new Stack<char>();
                queue = new Queue<char>();
            }

            void pushCharacter(char ch)
            {
                stack.Push(ch);
            }

            char popCharacter()
            {
                return stack.Pop();
            }

            void enqueueCharacter(char ch)
            {
                queue.Enqueue(ch);
            }

            char dequeueCharacter()
            {
                return queue.Dequeue();
            }
        }
    }
}
