using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the game
            Console.WriteLine("Welcome soldier. What is your given name");
            string playerName = Console.ReadLine();
            

            Console.WriteLine("What is type? " +
                    "1: Barbarian " +
                    "2: Idiot " +
                    "3: Walking Dead"
                    );
            string playerType = Console.ReadLine();
            Console.WriteLine(playerType);

            Console.WriteLine("What level are you? (1-50)");
            string playerLevel = Console.ReadLine();
            int numVal = int.Parse(playerLevel);
            Console.WriteLine(numVal);
            


            Console.WriteLine();




            //Player Isaac = new Player();

            //Creature Zedd = new Creature();
    }
    }
}
