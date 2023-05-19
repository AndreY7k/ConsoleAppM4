using System.Drawing;
using System.Security.Cryptography;

namespace ConsoleAppM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach (char color in name)
            {
                Console.Write($"{color + " "}");     
            }
            Console.WriteLine($"Последняя буква вашего имени: { name[name.Length - 1]}");

            Console.ReadKey();
        }
    }
}