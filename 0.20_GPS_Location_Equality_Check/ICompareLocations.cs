using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_GPS_Location_Equality_Check
{
    interface ICompareLocations
    {
        float P1_Location();
        float P2_Location();
        bool CompareLocationsMethod(float P1L, float P2L);
    }
}
