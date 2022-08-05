using EasyBrokeAPI_Connector.Data.Repositories.Contact;
using EasyBrokeAPI_Connector.Model.Contact;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyBrokeAPI_Connector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContact iContact;

        public ContactController(IContact iContact) => this.iContact = iContact;

        // GET: api/<Contact>
        [HttpGet]
        public async Task<IActionResult> GetContactRequest(int page, int limit, string happened_after, string happened_before, string property_id)
        {
            string queryParams = Request.QueryString.Value;
            return Ok(await iContact.GetContactRequest(queryParams));
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
