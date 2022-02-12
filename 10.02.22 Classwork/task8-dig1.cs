using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Дано целое число. Найти количество его цифр и их сумму.
 */
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int n = 0;
            int s = 0;

            while (a > 0)
            {
                int b = a % 10;
                a /= 10;
                n += 1;
                s += n;
            }

            Console.WriteLine($"Сумма: {s}, Количество: {n}");
        }
    }
}
