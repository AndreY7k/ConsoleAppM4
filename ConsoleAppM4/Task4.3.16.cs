﻿/*
namespace ConsoleAppM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
Первый вариант.

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int sum = 0;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
            
Второй вариант.
            
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int sum = 0;
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
*/