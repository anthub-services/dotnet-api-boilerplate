using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotNet_API_Boilerplate.Controllers
{
    [Route("[controller]")]
    public class IndexController : Controller
    {
        // GET: index
        [HttpGet]
        public string Get()
        {
            return "Welcome to dotNet API Boilerplate!";
        }
    }
}
