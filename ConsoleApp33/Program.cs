using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    /// <summary>
    ///  Составьте программу вычисления суммы 150 первых членов арифметической прогрессии, если a1= –200; d = 0,2.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = -200;
            double d = 0.2;
            int count = 1;
            double sum = 0;
            while (count <= 150)
            {
                a += d;
                count++;
                sum += a;
            }
            Console.WriteLine($"Сумма={sum}");
            Console.ReadKey();
        }
    }
}
