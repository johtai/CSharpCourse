using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Дано двузначное целое число. Вывести его правую и левую цифры. (Операции %, /)
Замечание: число –56 состоит из цифр 5 и 6, но не –5 и –6.
 */
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            var f = a / 10;
            var s = a % 10;

            if (a < 0)
            {
                f *= -1;
                s *= -1;
            }
            Console.WriteLine($"Первая часть: {f}");
            Console.WriteLine($"Вторая часть: {s}");
        }
    }
}
