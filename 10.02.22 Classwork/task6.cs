using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Заданы вещественные числа A, B, H (A < B, H > 0). Вывести значения функции синуса на промежутке от A до B с шагом H.
 */
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double h = 0.1;

            for (double x = a; x <= b; x += h)
            {
                Console.WriteLine(Math.Sin(x));
            }

        }
    }
}
