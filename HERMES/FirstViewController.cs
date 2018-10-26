using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;
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
            string url = "https://raw.githubusercontent.com/DevAdminT/HERMES/master/HERMES/FillUpLocation.xml";
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader XmlIn = XmlReader.Create(url, settings);

            if (XmlIn.ReadToDescendant("FillUpLocation"))
            {
                do
                {
                    FillUpLocation a = new FillUpLocation();
                    a.LocationName = XmlIn["Name"];
                    XmlIn.ReadStartElement("FillUpLocation");
                    a.Crossroad1 = XmlIn.ReadElementContentAsString();
                    a.Crossroad2 = XmlIn.ReadElementContentAsString();
                    a.City = XmlIn.ReadElementContentAsString();
                    a.State = XmlIn.ReadElementContentAsString();

                    allLocations.Add(a);
                }
                while (XmlIn.ReadToNextSibling("FillUpLocation"));
            }
            XmlIn.Close();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
