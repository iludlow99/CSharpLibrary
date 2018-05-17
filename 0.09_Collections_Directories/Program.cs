using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collections_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(new KeyValuePair<int, string>(2000, "Gladiator"));
            dict.Add(new KeyValuePair<int, string>(2001, "A Beautiful Mind"));
            dict.Add(new KeyValuePair<int, string>(2002, "Chicago"));
            dict.Add(new KeyValuePair<int, string>(2003, "The Lord of the Rings: The Return of the King"));
            dict.Add(new KeyValuePair<int, string>(2004, "Million Dollar Baby"));
            dict.Add(new KeyValuePair<int, string>(2005, "Crash"));

            //dict.Add(3, "Three");
            //dict.Add(100, "Hundred");
            Console.WriteLine();
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }

            Console.Write("Press <Enter> to exit... ");
            //while (Console.ReadKey().Key != ConsoleKey.Enter ConsoleKey.D2) { }

            //Console.WriteLine("Please type a year in the space below to show the movie that won:");
            //while (Console.ReadKey().Key = ConsoleKey.Enter) { }

            
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
