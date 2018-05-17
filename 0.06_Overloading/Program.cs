using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player idiot = new Player();
            idiot.Attack();
            idiot.Attack(5);
            idiot.Attack(5, "Wet Sticker");

            Console.ReadLine();
        }

    }
}
