using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603529Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        [HttpPost]
        [Route("api/Greeting")]
        public string GreetingPost() {
            return "Hello World!";
        }

        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string GreetingGet(int id) 
        {
            return "Greeting to " + id + " people!";
        }
    }
}
