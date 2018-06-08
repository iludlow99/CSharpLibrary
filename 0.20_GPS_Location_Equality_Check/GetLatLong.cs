using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_GPS_Location_Equality_Check
{
    internal struct GetLatLong
    {
        internal static float GetLatitude()
        {
            Console.Write("Type in the latitude: ");
            string p1_lat_str = Console.ReadLine();
            float p1_lat = float.Parse(p1_lat_str, CultureInfo.InvariantCulture.NumberFormat);
            return p1_lat;
        }

        internal static float GetLongitude()
        {
            Console.Write("Type in the longitude:");
            string p1_long_str = Console.ReadLine();
            float p1_long = float.Parse(p1_long_str, CultureInfo.InvariantCulture.NumberFormat);
            return p1_long;
        }
    }
}
