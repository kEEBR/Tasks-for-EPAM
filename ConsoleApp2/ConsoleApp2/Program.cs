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
            int numb, n, y = 0;
            string s;
            Console.Write("Введите количество элементов массива: ");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            Console.WriteLine("Введите массив: ");
            int i;
            int[] array = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("-> ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                y = array[i];
            }
            Console.Write("Введите число для проверки нахождения его в массиве: ");
            numb = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for(i=0;i<n;++i)
            {
                 if (array[i]==numb)
                {
                    Console.WriteLine("Введённое вами число " + numb + " совпадает с числом из массива!");
                    Console.WriteLine(array[i] + " = " + numb);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Число " + numb + " отсутсвует в массиве");
                return;
            }
            Console.ReadKey();
        }
    }
}
