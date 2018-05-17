using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
                                        /* We don't need to check to see if displayMenu is true bc the while loop by definition checks that. 
                                           A while loop will only run while the parameter passed is true */
                while(displayMenu /*== true*/)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option: (enter a number please)");
            Console.WriteLine("1) Option 1 ");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Option 3");
            Console.WriteLine("4) Exit");
            Console.WriteLine();
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if(result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number:");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= result)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing Game!");
            Console.ReadLine();
        }
    }
}
