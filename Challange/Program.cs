using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix movie1 = new Netflix("Name1", "Genre1", 7);

            Console.WriteLine(movie1);
            Console.ReadLine();

        }
    }
}
