using System;

namespace HERMES
{
    public class FillUpLocation
    {
        public static string Longitude { get; set; }
        public static string Latitude { get; set; }
        public static string Altitude { get; set; }

        public FillUpLocation (string theLong, string theLat, string theAlt)
        {
            Longitude = theLong;
            Latitude = theLat;
            Altitude = theAlt;
        }

        public FillUpLocation()
        {
        }
    }
}
