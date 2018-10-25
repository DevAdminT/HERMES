using System;
using System.Collections.Generic;
using System.IO;
using UIKit;

namespace HERMES
{
    public partial class FirstViewController : UIViewController
    {
        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //test comment to validate
            List<FillUpLocation> allLocations = new List<FillUpLocation>();

            StreamReader sr = new StreamReader("/Users/tyleryork/Projects/DevAdminT/HERMES.git/HERMES/FillUpLocation.txt");

            var line = sr.ReadLine();
            while(line !=null)
            {
                FillUpLocation a = new FillUpLocation();
                a.LocationName = line.Substring(0, line.IndexOf('|'));
                line = line.Remove(0, line.IndexOf('|')+1);
                a.Crossroad1 = line.Substring(0, line.IndexOf('|'));
                line = line.Remove(0, line.IndexOf('|')+1);
                a.Crossroad2 = line.Substring(0, line.IndexOf('|'));
                line = line.Remove(0, line.IndexOf('|')+1);
                a.City = line.Substring(0, line.IndexOf('|'));
                line = line.Remove(0, line.IndexOf('|')+1);
                a.State = line;
                allLocations.Add(a);
                line = sr.ReadLine();

            }
            

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
