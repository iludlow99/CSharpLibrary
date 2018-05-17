using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = "Issac";

            switch (student)
            {
                case "Dude":
                        Console.WriteLine("Dude");
                    break;
                default:
                    Console.WriteLine("bah");
                    break;
            }

            Console.ReadLine();
        }
    }
}
