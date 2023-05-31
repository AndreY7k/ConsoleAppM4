using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleAppM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Практическое задание

            (string UserName, string UserSurame, string UserLogin, double UserLengthLogin, bool HavingPet, double UserAge, string[] favcolors) User;

            for (int k = 0; k < 3; k++)
            {
                Console.Write("Введите ваше имя: ");
                User.UserName = Console.ReadLine();
                Console.Write("Введите вашу фамилию: ");
                User.UserSurame = Console.ReadLine();
                Console.Write("Введите логин: ");
                User.UserLogin = Console.ReadLine();
                User.UserLengthLogin = User.UserLogin.Length;

                Console.WriteLine("Есть ли у вас домашнее животное? \n Ответ дайте в формате: Да или Нет");
                var result = Console.ReadLine();
                
                if (result == "Да")
                {
                    User.HavingPet = true;
                }
                else
                {
                    User.HavingPet = false;
                }
                
                Console.Write("Введите ваш возраст: ");
                User.UserAge = Convert.ToInt32(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета: ");
                
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}