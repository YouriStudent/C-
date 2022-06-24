using System;

namespace opdracht_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array_2d = {
                { 1,2,3,4,5},
                { 6,7,8,9,10},
                { 8,9,10,11,12},
                { 10,13,11,19,15 }
            };
            for (int i = 0; i < array_2d.GetLength(0); i++)
            {
                int highestCount = 0;
                for(int j = 0; j < array_2d.GetLength(1); j++)
                {
                    int currentValue = array_2d[i, j];
                    if (highestCount < currentValue)
                    {
                        highestCount = currentValue;
                    }
                }
                Console.WriteLine(highestCount);
            }
        }
    }
}
