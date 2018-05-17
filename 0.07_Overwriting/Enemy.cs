
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overwriting
{
    class Enemy : Character
    {
        public override void HealAlly()
        {
            Console.WriteLine("The enemy damaged the player");
        }
    } 
}
