﻿using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;

namespace ConsoleAppM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, -2, 5, -6, -3, 12, 45, 67, -78, 15, -89 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {                
                if (array[i] > 0)
                {
                    sum++;
                }                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}