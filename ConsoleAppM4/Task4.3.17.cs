﻿/*
namespace ConsoleAppM4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //От меньшего к большему
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            var array = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = array;
                        }
                    }
                }
            }
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                    Console.Write(arr[i, k] + " ");

                Console.WriteLine();
            }

            //ОТ большего к меньшему 
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] < arr[i, k])
                        {
                            var sum = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = sum;
                        }
                    }
                }
            }
            for (int i = 0; i < arr.GetUpperBound(0) + 1;  i++)
            {
                for(int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr[i, j] + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
*/