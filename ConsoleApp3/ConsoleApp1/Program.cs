using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Привет студент привет школьник привет работник";
            var res = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .GroupBy(a => a)
              .Where(a => a.Count() == 1)
              .Select(a => a.Key);
            foreach (var item in res) Console.Write(item + " ");
            Console.ReadLine();
        }
    }
}
