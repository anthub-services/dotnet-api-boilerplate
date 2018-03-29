using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotNet_API_Boilerplate.Controllers
{
    [Route("[controller]")]
    public class SessionsController : Controller
    {
        // GET: sessions
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET sessions/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST sessions
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT sessions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE sessions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
