using EasyBrokeAPI_Connector.Data.Repositories.Property;
using EasyBrokeAPI_Connector.Model.Property;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq; 

namespace EasyBrokeAPI_Connector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : Controller
    {
        private readonly IProperty iProperty;

        public PropertyController(IProperty iProperty) => this.iProperty = iProperty;

        // GET: PropertyController
        // GET: api/<Contact>
        [HttpGet]
        public async Task<IActionResult> GetPropertiesRequest(string page, string limit)
        {
            string queryParams = Request.QueryString.Value;
            return Ok(await iProperty.GetPropertiesRequest(queryParams));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPropertyRequest(string id)
        {
            return Ok(await iProperty.GetPropertyRequest(id));
        }

        // POST api/<Contact>
        [HttpPost]
        public async void Post([FromBody] string value)
        {
        }

        // PUT api/<Contact>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Contact>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
        }

    }
}
