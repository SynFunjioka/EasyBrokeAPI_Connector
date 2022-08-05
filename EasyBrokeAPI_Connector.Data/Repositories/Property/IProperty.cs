using EasyBrokeAPI_Connector.Model.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Data.Repositories.Property
{
    public interface IProperty
    {
        Task<IEnumerable<PropertyForListModel>> GetPropertiesRequest(string queryParams);
        Task<IEnumerable<PropertySingleModel>> GetPropertyRequest(string id);
        Task<bool> InsertContact(PropertyForListModel contact);
        Task<bool> UpdateContact(PropertyForListModel contact);
        Task<bool> DeleteContact(PropertyForListModel contact);
    }
}
