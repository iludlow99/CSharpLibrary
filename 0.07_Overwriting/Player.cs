using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Overwriting
{
    class Player : Character
    {
        //Method
        public override void HealAlly()
        {
            Console.WriteLine("Character healed the other player");

        }
    }
}
