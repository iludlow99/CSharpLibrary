using System;
using _0._05_OOP_Game
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_Encapsolation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankPublic bankPublic = new BankPublic();
            decimal amount = bankPublic.GetAmount();
            Console.WriteLine("YOur balance is: {0}", amount);

            BankProtected bankProtected = new BankProtected();
            bankProtected.CloseAccount();

            Creature steave = new Creature();

            //public is open to the namespace
            //protected is open to the class and all derived classes
            //private is open only to the class itself

            Console.ReadLine();
        }
    }
}
