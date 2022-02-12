using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static double Perimeter(double x, double y, double z)
        {
            return x + y + z;
        }
        static double Dist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) - Math.Pow((y2 - y1), 2));
        }
        static double FloorCubicRoot(double n)
        {
            return Math.Truncate(Math.Pow(n, 1 / 3));
        }
        static void Minmax(ref double min, ref double max)
        {
            if (min > max)
            {
                double old_min = min;
                min = max;
                max = old_min;
            }
        }
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Введите 3 стороны треугольника:");
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            double z = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Периметр: {Perimeter(x, y, z)}");

            // 2
            Console.WriteLine("Введите 2 точки, каждую координату на новой строке:");
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());


            Console.WriteLine(Dist(x1, y1, x2, y2));

            // 3
            Console.WriteLine("Введите число n:");
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Наименьшее целое до кубического корня: {FloorCubicRoot(n)}");

            // 4
            Console.WriteLine("Введите min и max:");
            double min = Double.Parse(Console.ReadLine());
            double max = Double.Parse(Console.ReadLine());

            Minmax(ref min, ref max);
            Console.WriteLine($"min: {min}, max: {max}");

            // 5
            Console.WriteLine("Введите последовательность, 0 - конец:");
            int elem = 1;
            max = 0;
            min = 1000000000000000000;
            while (elem != 0)
            {
                elem = int.Parse(Console.ReadLine());

                if (elem > max)
                {
                    max = elem;
                }
                if ((elem < min) & (elem != 0))
                {
                    min = elem;
                }
            }
            Console.WriteLine($"min: {min}, max: {max}");
        }
        
    }
}
