using System;
using UIKit;
using Foundation;
using HERMES;
using CoreLocation;

namespace HERMES
{
    public class FillUp
    {
        public DateTime FillUpDate { get; set; }
        public float CarMileage { get; set; }
        public float TripMileage { get; set; }
        public float FillUpGallons { get; set; }
        public float CostPerGallon { get; set; }
        public FillUpLocation TheLocation { get; set; }


        public FillUp(float a, float b, float c, float d, FillUpLocation e)
        {
            FillUpDate = DateTime.Now;
            CarMileage = a;
            TripMileage = b;
            FillUpGallons = c;
            CostPerGallon = d;
            TheLocation = e;
           
        }
        public FillUp()
        {
        }

    }
    public class FillUpLocation
    {
        public string LocationName { get; set; }
        public string Crossroad1 { get; set; }
        public string Crossroad2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public FillUpLocation(string theLocation, string the1, string the2, string theCity, string theState)
        {
            LocationName = theLocation;
            Crossroad1 = the1;
            Crossroad2 = the2;
            City = theCity;
            State = theState;
        }

        public FillUpLocation()
        {}

        public override string ToString()
        {
            return LocationName + " - " + Crossroad1 + " & " + Crossroad2;
        }
    }
}
