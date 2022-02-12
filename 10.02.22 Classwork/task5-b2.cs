using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
Даны три целых числа. Вывести значение true, если любые два из них не равны между собой,
и false в противном случае. (Операция проверки на неравенство: !=, логическое И: &&.)
Указание: условный оператор не использовать.
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

            Console.WriteLine((a != b) && (a != c) && (b != c));

        }
    }
}
