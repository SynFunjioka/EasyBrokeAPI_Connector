using EasyBrokeAPI_Connector.Model.Agent;
using EasyBrokeAPI_Connector.Model.Features;
using EasyBrokeAPI_Connector.Model.Location;
using EasyBrokeAPI_Connector.Model.Operations;
using EasyBrokeAPI_Connector.Model.Property;
using EasyBrokeAPI_Connector.Model.PropertyImages;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Data.Repositories.Property
{
    public class PropertyRepository : IProperty
    {
        string url = Environment.GetEnvironmentVariable("EB_URL");

        public Task<bool> DeleteContact(PropertyForListModel contact)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PropertyForListModel>> GetPropertiesRequest(string queryParams)
        {
            string urlContact = url + "properties" + queryParams;
            List<PropertyForListModel> properties = new List<PropertyForListModel>();
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

                                if (dataObj.ContainsKey("error"))
                                    return null;

                                var allData = dataObj["content"];

                                foreach (JObject propperty in allData)
                                {

                                    properties.Add(ModelCreator.CreatePropertyForList(propperty));
                                }

                                Console.WriteLine("The contacts: \n", properties);
                                return properties;
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

        public async Task<IEnumerable<PropertySingleModel>> GetPropertyRequest(string id)
        {
            string urlContact = url + "properties/" + id;
            List<PropertySingleModel> properties = new List<PropertySingleModel>();
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

                                if (dataObj.ContainsKey("error"))
                                    return null;

                                properties.Add(ModelCreator.CreateSingleProperty(dataObj));


                                Console.WriteLine("The contacts: \n", properties);
                                return properties;
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
        public Task<bool> InsertContact(PropertyForListModel contact)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContact(PropertyForListModel contact)
        {
            throw new NotImplementedException();
        }
    }
}
