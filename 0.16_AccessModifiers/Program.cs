using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            var person = new Person();
            person.SetDate(new DateTime(1999, 07, 04));

            Console.WriteLine(person.GetDate());
            

        }
    }
}
