using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Property
{
    public class PropertySearchParamsModel
    {
        public string UpdatedAfter{ get; set; }
        public string UpdatedBefore{ get; set; }
        public string OperationType{ get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int MinBedrooms { get; set; }
        public int MaxBedrooms { get; set; }
        public int MinParkingSpaces { get; set; }
        public int MinConstructionSize { get; set; }
        public int MaxConstructionSize { get; set; }
        public int MinLotSize { get; set; }
        public int MaxLotSize { get; set; }
    }
}
