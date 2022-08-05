using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Contact
{
    public class ContactModelParameters
    {
        public  int page { get; set; }
        public int limit { get; set; }
        public string happened_after { get; set; }
        public string happened_before { get; set; }
        public string property_id { get; set; }
    }
}
