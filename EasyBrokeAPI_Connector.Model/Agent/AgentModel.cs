using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Agent
{
    public class AgentModel
    {
        public AgentModel(int id, string name, string fullName, string mobilePhone, string profileImageURL, string email)
        {
            ID = id;
            Name = name;
            FullName = fullName;
            MobilePhone = mobilePhone;
            ProfileImageURL = profileImageURL;
            Email = email;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string MobilePhone { get; set; }
        public string ProfileImageURL { get; set; }
        public string Email { get; set; }
    }
}