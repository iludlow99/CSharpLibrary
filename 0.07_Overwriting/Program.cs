using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overwriting
{
    class Program
    {
        static void Main(string[] args)
        {

            //Character
            Character quincy = new Character();
            quincy.HealAlly();

            //PLayer
            Player jenn = new Player();
            jenn.HealAlly();

            //Enemy
            Enemy Aaron = new Enemy();
            Aaron.HealAlly();

            Console.ReadLine();
        }
    }
}
