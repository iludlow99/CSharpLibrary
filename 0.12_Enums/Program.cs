using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Weekday day = Weekday.Wednesday;

            switch (day)
            {
                case Weekday.Monday:
                    Console.WriteLine("Ugh it's Monday");
                    break;
                case Weekday.Tuesday:
                    Console.WriteLine("Tuesday is the day");
                    break;
                case Weekday.Wednesday:
                    Console.WriteLine("HUMP DAY!");
                    break;
                case Weekday.Thursday:
                    Console.WriteLine("Yep.");
                    break;
                case Weekday.Friday:
                    Console.WriteLine("It's almost the weekenddd");
                    break;
                case Weekday.Saturday:
                    Console.WriteLine("Saturday is a special say");
                    break;
                default:
                    break;
            }

            Console.ReadLine();






        }
    }



    enum Weekday
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6

    }



}
