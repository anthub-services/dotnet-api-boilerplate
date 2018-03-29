using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotNet_API_Boilerplate.Controllers
{
    [Route("api/[controller]")]
    public class SessionController : Controller
    {
        // GET: api/session
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/session/7
        [HttpGet("id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/session
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/session/7
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/session/7
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
