using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game
{
    class Creature : Character
    {
        //Constructor
        public Creature (string firstName, int creatureLevel, int currentPowerLevel, string creatureType, bool lowPower)
        {
            this.PlayerName = firstName;
            this.Level = creatureLevel;
            this.Type = creatureType;
            this.IsLowOnPower = lowPower;
            this.CurrentPower = currentPowerLevel;
        }

        public string PlayerName { get; set; }
    }
}

