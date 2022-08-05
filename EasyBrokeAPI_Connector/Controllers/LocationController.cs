using EasyBrokeAPI_Connector.Data.Repositories.Location;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocation iLocation;

        public LocationController(ILocation iLocation) => this.iLocation = iLocation;

        // GET: api/<Contact>
        [HttpGet]
        public async Task<IActionResult> GetLocationRequest(string query)
        {
            string queryParams = Request.QueryString.Value;
            return Ok(await iLocation.GetPropertiesRequest(queryParams));
        }
    }
}
