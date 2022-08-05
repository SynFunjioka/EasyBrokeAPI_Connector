using EasyBrokeAPI_Connector.Model.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Data.Repositories.Location
{
    public interface ILocation
    {
        Task<IEnumerable<LocationListModel>> GetPropertiesRequest(string location);
    }
}
