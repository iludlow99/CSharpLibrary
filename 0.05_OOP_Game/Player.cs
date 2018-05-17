using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game
{
    class Player : Character
    {
        //Constructor
        public Player(string firstName, int playerLevel, int currentPlayerPowerLevel, string playerType, bool playerIsLowOnPower)
        {
            this.PlayerName = firstName;
            this.Level = playerLevel;
            this.Type = playerType;
            this.IsLowOnPower = playerIsLowOnPower;
            this.CurrentPower = currentPlayerPowerLevel;
        }

        public string PlayerName { get; set; }
    }

}
