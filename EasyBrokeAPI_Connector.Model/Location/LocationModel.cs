using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Location
{
    public class LocationModel
    {
        public LocationModel(string name, double latitude, double longitude, string street, string postalCode, bool showExactLocation, string exteriorNumber, string interiorNumber)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Street = street;
            PostalCode = postalCode;
            ShowExactLocation = showExactLocation;
            ExteriorNumber = exteriorNumber;
            InteriorNumber = interiorNumber;
        }

        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public bool ShowExactLocation { get; set; }
        public string ExteriorNumber { get; set; }
        public string InteriorNumber { get; set; }
    }
}