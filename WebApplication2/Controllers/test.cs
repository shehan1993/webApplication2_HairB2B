using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class test : ApiController
    {
        string[] listOfSearch = { "ABC", "DEF", "GHI" };

        static List<string> strings = new List<string>()
        {
            "value0","value1","value2"
        };

        
        public IEnumerable<string> Get()
        {
            return strings;
        }

    }
}
