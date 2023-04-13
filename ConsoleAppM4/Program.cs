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

        }
    }
}