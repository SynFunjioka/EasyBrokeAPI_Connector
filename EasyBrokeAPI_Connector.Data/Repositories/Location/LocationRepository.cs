using EasyBrokeAPI_Connector.Model.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace EasyBrokeAPI_Connector.Data.Repositories.Location
{
    public class LocationRepository : ILocation
    {
        string url = Environment.GetEnvironmentVariable("EB_URL");
        public async Task<IEnumerable<LocationListModel>> GetPropertiesRequest(string query)
        {
            string urlContact = url + "locations" + query;
            List<LocationListModel> properties = new List<LocationListModel>();
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

                                properties.Add(ModelCreator.CreateLocationList(dataObj));


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
    }
}
