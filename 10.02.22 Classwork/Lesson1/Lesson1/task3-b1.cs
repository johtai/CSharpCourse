using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Даны три целых числа: A, B, C. Вывести значение true, если справедливо двойное неравенство
A < B < C, и false в противном случае. Указание: условный оператор не использовать.

*/
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a < b) & (b < c))
            {
                Console.WriteLine("true");
            }
            else 
                Console.WriteLine("false");
        }
    }
}
