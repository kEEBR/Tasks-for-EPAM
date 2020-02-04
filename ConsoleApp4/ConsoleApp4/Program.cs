using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static long Factorial(int n)
        {
            long fact = 1;
            if (n != 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    fact *= i;
                }
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine($"Факториал числа {n}: {Factorial(n)}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введено отрицательное число!");
            }
            Console.ReadKey();
        }
    }
}