using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constuctors
{
    public abstract class Character
    {
        public Character(string username)
        {
            this.Username = username;
        }

        public Character(string username, int age)
        {
            this.Username = username;
            this.Age = age;
        }

        public Character(string username, int age, int health)
        {
            this.Username = username;
            this.Age = age;
            this.Health = health;

        }

        //PROPORTIES
        public string Username { get; set; }
        public int Age{ get; set; }
        public int Health { get; set; }
    }
}
