using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Features
{
    public class FeatureModel
    {
        public FeatureModel(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public string Name { get; set; }
        public string Category { get; set; }
    }
}