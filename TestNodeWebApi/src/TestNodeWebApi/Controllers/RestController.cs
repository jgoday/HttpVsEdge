using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TestNodeWebApi.Controllers
{
    public class Person
    {
        public string Name { get; set; }
    }

    [Route("api/[controller]")]
    public class RestController : Controller
    {
        // GET api/values/5
        [HttpGet("{name}")]
        public Person Get(string name)
        {
            var p = new Person { Name = name };
            return p;
        }
    }
}
