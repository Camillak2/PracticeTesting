using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, y;
            Console.Write("Введите a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Некорректное значение a. Введите корректное значение.");
                continue;
            }
            Console.Write("Введите b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Некорректное значение b. Введите корректное значение.");
                continue;
            }
            Console.Write("Введите c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Некорректное значение c. Введите корректное значение.");
                continue;
            }
            Console.Write("Введите x: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Некорректное значение c. Введите корректное значение.");
                continue;
            }
            if (x < 3 && b != 0)
            {
                y = a * Math.Pow(x, 2) - b * x + c;
                Console.WriteLine($"y = {y}");
            }
            else if (x > 0 && b == 0)
            {
                if (x == c)
                {
                    Console.WriteLine("Знаменатель равен 0, так как х = с. Деление на 0 невозможно.");
                }
                else
                {
                    y = (x - a) / (x - c);
                    Console.WriteLine($"y = {y}");
                }
            }
            else
            {
                if (c == 0)
                {
                    Console.WriteLine("C равен 0. Деление на 0 невозможно.");
                }
                else
                {
                    y = x / c;
                    Console.WriteLine($"y = {y}");
                }
            }
            Console.ReadKey();
        }
    }
}
