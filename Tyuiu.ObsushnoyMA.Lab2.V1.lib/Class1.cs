using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ObsushnoyMA.Lab2.V1.lib
{
    public class DataService
    {
        public string[] GetMassFunction(int startValue, int stopValue)
        {
            List<string> results = new List<string>();

            for (int x = startValue; x <= stopValue; x++)
            {
                double xSquared = Math.Pow(x, 2);
                double numerator = xSquared - Math.Cos(xSquared) + Math.PI;
                double denominator = xSquared - Math.Sin(xSquared) + 12;

                if (Math.Abs(denominator) < 1e-10) // Проверка деления на ноль
                {
                    results.Add("-");
                }
                else
                {
                    double result = numerator / denominator;
                    results.Add(result.ToString("F2")); // Округление до двух знаков
                }
            }

            return results.ToArray();
        }
    }
}
