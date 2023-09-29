using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01603529Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public string Get(int id)
        {
            int fortnight = (id / 14) + 1;
            double price = Math.Round(fortnight * 5.5, 2);
            
            double tax = Math.Round(price * 0.13, 2);
            double total = price + tax;
            return fortnight + " fortnight at $5.50/FN = $" + string.Format("{0:0.00} ", price) + " CAD HST 13% = $"+ string.Format("{0:0.00} ", tax) + " CAD Total = $"+total+" CAD";
        }
    }
}
