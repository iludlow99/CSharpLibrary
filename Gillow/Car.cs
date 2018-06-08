using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gillow
{
    class Car
    {
        public Car(/*int id,*/ string brand, string model, string color)
        {
            //Id = id;
            Brand = brand;
            Model = model;
            Color = color;
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}
