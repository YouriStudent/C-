using System;
using System.Collections.Generic;

namespace opdracht_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(8);
            stack.Push(4);
            stack.Push(2);
            stack.Push(1);

            Stack<int> stack2 = new Stack<int>();
            stack2.Push(10);
            stack2.Push(9);
            stack2.Push(5);
            stack2.Push(3);

            while (stack.Count > 0 || stack2.Count > 0)
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(stack2.Pop());
                    continue;
                }
                if (stack2.Count == 0)
                {
                    Console.WriteLine(stack.Pop());
                    continue;
                }

                if(stack.Peek() > stack2.Peek())
                {
                    Console.WriteLine(stack2.Pop());
                }
                else
                {
                    Console.WriteLine(stack.Pop());
                }
            }

        }
    }
}
