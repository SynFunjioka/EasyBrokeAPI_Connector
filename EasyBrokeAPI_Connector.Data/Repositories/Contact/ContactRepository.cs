using EasyBrokeAPI_Connector.Model;
using EasyBrokeAPI_Connector.Model.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace EasyBrokeAPI_Connector.Data.Repositories.Contact
{
    public class ContactRepository : IContact
    {
        string url = Environment.GetEnvironmentVariable("EB_URL");

        public Task<bool> DeleteContact(ContactModel contact)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContactModel>> GetContactRequest(string queryParams)
        {
            string urlContact = url + "/contact_requests" + queryParams;
            List<ContactModel> contacts =  new List<ContactModel>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-Authorization", Environment.GetEnvironmentVariable("API_KEY"));
                   
                    using (HttpResponseMessage res = await client.GetAsync(urlContact))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                Console.WriteLine("Data without format: ", data);
                                var dataObj = JObject.Parse(data);
                                var allData = dataObj["content"];

                                foreach (JObject contact in allData)
                                {
                                    ContactModel contactModel = new ContactModel(
                                    userName: $"{contact["name"]}",
                                    phone: $"{contact["phone"]}",
                                    email: $"{contact["email"]}",
                                    id: $"{contact["property_id"]}",
                                    message: $"{contact["message"]}",
                                    source: $"{contact["source"]}",
                                    happenedAt: $"{contact["happened_at"]}"
                                    );

                                    contacts.Add(contactModel);
                                }

                                Console.WriteLine("The contacts: \n", contacts);
                                return contacts;
                            }
                            else
                            {
                                Console.WriteLine("----------NO Data----------");
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("-----------Exception------------");
                Console.WriteLine(exception);
            }

            return null;
        }

        public Task<bool> InsertContact(ContactModel contact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContact(ContactModel contact)
        {
            throw new NotImplementedException();
        }
    }
}