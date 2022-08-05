using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Contact
{
    public class ContactModel
    {
        public ContactModel(string userName, string phone, string email, string id, string message, string source, string happenedAt)
        {
            UserName = userName;
            Phone = phone;
            Email = email;
            ID = id;
            Message = message;
            Source = source;
            HappenedAt = happenedAt;
        }

        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }
        public string Message { get; set; }

        public string Source { get; set; }

        public string HappenedAt { get; set; }
    }
}
