using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gillow
{
    class Cars
    {
        private List<Car> myCarList { get; set; }

        public Cars()
        {
            myCarList = new List<Car>();
        }

        public void AddCar(Car car)
        {
            myCarList.Add(car);
        }
    }
}
