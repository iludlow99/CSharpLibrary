using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Overloading
{
    class Player
    {
        public void Attack()
        {
            Console.WriteLine("The player attacked for some points");
        }

        public void Attack(int points)
        {
            Console.WriteLine("The player was attacked for {0} points", points);
        }

        public void Attack(int points, string weapon)
        {
            Console.WriteLine("The player was attacked for {0} with a {1}", points, weapon);
        }
    }
}
