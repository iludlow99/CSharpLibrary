using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._20_GPS_Location_Equality_Check
{
    internal class Execute
    {

        //Console.WriteLine(CompareLocations.sameLocation);

        //Console.WriteLine("Helloooo you have reached the end of the code. Good job!");
    
        //bool sameLocation = yourLocation.Equals(P2Location);
        internal float personLatitude = GetLatLong.GetLatitude();
        internal float personLongitude = GetLatLong.GetLongitude();

        public static void Runprogram()
        {
            Console.WriteLine("Your location");
            Coordinates yourLocation = CreateCoordinates(personLatitude, personLongitude);

            Console.WriteLine("Their location");
            Coordinates theirLocation = CreateCoordinates(personLatitude, personLongitude);

            Console.WriteLine("Your program is runing");
            Console.WriteLine();
            Console.WriteLine(theirLocation);
        }
        
        public static Coordinates CreateCoordinates(float personLatitude, float personLongitude)
        {
       
            Coordinates coordinates = new Coordinates(personLatitude, personLongitude);

            return coordinates;
        }
    }
}
