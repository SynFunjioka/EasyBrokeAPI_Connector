using EasyBrokeAPI_Connector.Model;
using EasyBrokeAPI_Connector.Model.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Data.Repositories.Contact
{
    public interface IContact
    {
        Task<IEnumerable<ContactModel>> GetContactRequest(string queryParams);
        Task<bool> InsertContact(ContactModel contact);
        Task<bool> UpdateContact(ContactModel contact);
        Task<bool> DeleteContact(ContactModel contact);

    }
}
