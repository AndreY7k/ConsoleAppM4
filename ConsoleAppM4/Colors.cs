using System.Drawing;
using System.Security.Cryptography;

namespace ConsoleAppM4
{
    internal class Program5
    {
        static void Main(string[] args)
        {

            //Добавить новый цвет консоли.

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");

            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            //Добавить новый цвет консоли через конструкцию switch.\
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

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
            // return — это выход из метода.

            // goto case — позволяет перейти к другому условию внутри блока switch.

            // throw применяется для выбора ошибок.
        }
    }
}