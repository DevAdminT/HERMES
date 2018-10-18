using System;
using UIKit;
using Foundation;
using HERMES;
using CoreLocation;

namespace HERMES
{
    public class FillUp
    {
        public FillUp()
        {
        }

        public static FillUpLocation GetCurrentLocation ()
        {
            CLLocationManager LocationManager = null;
            FillUpLocation theLocation = null;
            LocationManager.DesiredAccuracy = 1000;
            LocationManager.UpdatedLocation += (object sender, CLLocationUpdatedEventArgs e) =>
            {
                theLocation = UpdateLocation(e.NewLocation);
            };

                return theLocation;
        }
        static public FillUpLocation UpdateLocation(CLLocation newLocation)
        {
            FillUpLocation theLocation = new FillUpLocation (newLocation.Coordinate.Longitude.ToString(),
                                                            newLocation.Coordinate.Latitude.ToString(),
                                                            newLocation.Altitude.ToString());

            return theLocation;
        }
    }
}
