using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetDate()
        {
            return _birthdate;
        }
    }
}
