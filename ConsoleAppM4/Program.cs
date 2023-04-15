using System.Drawing;

namespace ConsoleAppM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            //Задание 4.1.4
            string A;
            string B;

            bool C = A != B;

            //Задание 4.1.5
            int A1;
            int B1;
            double X1;
            double Y1;

            bool c = (A1 < B1) | (X1 > Y1);

            Операция " ^ " возвращает "true" только когда одна из половин равна true
            а вторая половина равна false 
            var a = 6;
            var b = 7;

            var c = (a > b) ^ (a != b);

            //Задание 4.1.10
            var inv = true;
            var result = !inv;

            Console.WriteLine(result);
            Console.ReadKey(); 
            
             */

            //Задание 4.1.12

            var A2 = 6;
            var B2 = 7;

            if (A2 != B2)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }

            var a3 = 6;
            var b3 = 7;

            if (a3 == b3)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");

                if (b3 < 10)
                    Console.WriteLine("Значение b = {0}", b3);
            }
            
            Console.ReadKey();

            //Добавить новый цвет консоли.
            
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            
            } else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");

            } else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            //Добавить новый цвет консоли через конструкцию switch.
            
            var color1 = Console.ReadLine();

            switch (color1) 
            {
                case "red":

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":

                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                default:

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
            }

        }
    }
}