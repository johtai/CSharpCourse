using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Вычислить среднее арифметическое двух заданных целых чисел. Указание: для того, чтобы деление
 * выполнялось вещественным образом, нужно, чтобы один из операндов был вещественный, самый простой
 * способ добиться этого в данном случае — использовать литерал 2.0 в качестве делителя.
 */
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифм.: {(a + b) / 2.0}");
        }
    }
}
