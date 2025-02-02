using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    /// <summary>
    /// Родители ко дню рождения своего сына Андрея решили купить и обновить ему мобильный телефон.
    /// Для этого они в первый месяц отложили 100 руб., а в каждый последующий на 50 рублей больше. 
    /// Какая сумма будет через десять месяцев?
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int d = 50;
            int count = 1;
            int sum = 0;
            while (count <= 10)
            {
                sum += a;
                a += d;
                count++;
            }
            Console.WriteLine($"Сумма = {sum} рублей");
            Console.ReadKey();
        }
    }
}
