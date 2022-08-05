using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Location
{
    public class LocationListModel
    {
        public LocationListModel(string name, string fullName, string type, LocalityModel[] localities)
        {
            Name = name;
            FullName = fullName;
            Type = type;
            Localities = localities;
        }

        public string Name { get; set; }
        public string FullName { get; set; }
        public string Type { get; set; }

        public LocalityModel[] Localities { get; set; }
    }
}
