using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Collestions_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var classList = new List<string>();
            classList.Add("Quincy");
            classList.Add("Spencer");
            classList.Add("Aaron M");
            classList.Add("Aaron M");

            foreach (var memeber in classList)
            {
                Console.WriteLine(memeber);
            }


            List<string> fuits = new List<string>()
            {
                "Banna", "Mango", "Pineapple", "Jackfuit", "Breadfuit"
            };

            Console.WriteLine(fuits.Capacity);


                Console.WriteLine(classList.Capacity);
                Console.ReadLine();
        }
    }
}
