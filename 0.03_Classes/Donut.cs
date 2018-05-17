using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Classes
{
    class Donut
    {
        //Properties
        public string Type{ get; set; }
        public bool HasCream { get; set; }
        public decimal Price { get; set; }
        public bool HasSprinkles { get; set; }

        //Calling a method
        public void PrintDonutType()
        {
            Console.WriteLine(this.Type);
        }
    }
}
