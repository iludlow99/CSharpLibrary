using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GettersSetters
{
    class Employee
    {

        //Feilds
        private int _id;



        //Proporties
        public int EmployeeID
        {
            set
            {
                if (EmployeeID < 1)
                    throw new Exception("The Employee ID is not valid");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

    }
}
