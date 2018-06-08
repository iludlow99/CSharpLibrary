using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gillow
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars carListOne = new Cars();

            var car1 = new Car("Honda", "Civic", "Red");

            carListOne.AddCar(car1);

            Console.WriteLine(carListOne);
        }
    }
}
