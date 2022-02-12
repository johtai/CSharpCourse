using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        enum DayOfWeek { MON = 1, TUE = 2, WED = 3, THU = 4, FRI = 5, SAT = 6, SUN = 7};

        //Выводит название дня недели
        static void PrintDayOfWeek(DayOfWeek dow)
        {
            switch (dow)
            {
                case DayOfWeek.MON:
                    Console.WriteLine("Monday");
                    break;
                case DayOfWeek.TUE:
                    Console.WriteLine("Tuesday");
                    break;
                case DayOfWeek.WED:
                    Console.WriteLine("Wednesday");
                    break;
                case DayOfWeek.THU:
                    Console.WriteLine("Thursday");
                    break;
                case DayOfWeek.FRI:
                    Console.WriteLine("Friday");
                    break;
                case DayOfWeek.SAT:
                    Console.WriteLine("Saturday");
                    break;
                case DayOfWeek.SUN:
                    Console.WriteLine("Sunday");
                    break;
            }

        }

        //Считывает день недели (от 1 до 7) и возвращает значение DayOfWeek
        static DayOfWeek ReadDayOfWeek()
        {
            int day;
            day = int.Parse(Console.ReadLine());

            if ((day < 0) & (day > 8) )
                throw new ArgumentOutOfRangeException("day", "day must be > 0 and <8; day=" + day.ToString());
            return (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day.ToString()); ;
        }
        static void Main()
        {
            DayOfWeek dow = ReadDayOfWeek();

            PrintDayOfWeek(dow);

        }

    }
}
