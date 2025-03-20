using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ObsushnoyMA.Lab2.V1.lib;

namespace Tyuiu.ObsushnoyMA.Lab2.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное значение: ");
            int start = Int32.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение: ");
            int stop = Int32.Parse(Console.ReadLine());

            if (start > stop)
            {
                Console.WriteLine("Ошибка: начальное значение не может быть больше конечного.");
                return;
            }

            DataService tabulator = new DataService();
            string[] result = tabulator.GetMassFunction(start, stop);

            Console.WriteLine("\n|  x   |    F(x)    |");
            Console.WriteLine("|------|------------|");

            for (int i = 0; i < result.Length; i++)
            {
                int xValue = start + i;
                Console.WriteLine("| {0,4} | {1,10} |", xValue, result[i]);
            }
        }
    }
}
