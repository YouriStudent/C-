using System;
using System.Collections.Generic;

namespace opdracht3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(1);
            q1.Enqueue(5);
            q1.Enqueue(10);

            Queue<int> q2 = new Queue<int>();
            q2.Enqueue(2);
            q2.Enqueue(8);
            q2.Enqueue(9);

            while(q2.Count > 0 || q1.Count > 0)
            {
                if(q1.Count == 0)
                {
                    Console.WriteLine(q2.Dequeue());
                    continue;
                }
                if(q2.Count == 0)
                {
                    Console.WriteLine(q1.Dequeue());
                    continue;
                }
                
                if(q1.Peek() < q2.Peek())
                {
                    Console.WriteLine(q1.Dequeue());
                }
                else
                {
                    Console.WriteLine(q2.Dequeue());
                }
            }

         
        }
    }
}
