using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Числа Пелля PN задаются рекурсивно: 

P0 = 0,  P1 = 1,  PN = 2 PN–1 + PN–2.
Вывести  N чисел Пелля (N ≥ 0).
 */
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n2 = 0;
            int n1 = 1;
            int N = int.Parse(Console.ReadLine());
            int n0 = 0;

            if (N == 1) { Console.WriteLine(n2); }
            else if (N == 2) { Console.WriteLine(n1); }
            else
            {
                for (var i = 2; i <= N; i++)
                {
                    n0 = 2 * n1 + n2;
                    n2 = n1;
                    n1 = n0;
                }

                Console.WriteLine(n0);
            }


        }
    }
}
