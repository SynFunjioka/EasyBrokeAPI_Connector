using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.PropertyImages
{
    public class PropertyImagesModel
    {
        public PropertyImagesModel(string url, string title)
        {
            URL = url;
            Title = title;
        }

        public string URL { get; set; }
        public string Title { get; set; }
    }
}
