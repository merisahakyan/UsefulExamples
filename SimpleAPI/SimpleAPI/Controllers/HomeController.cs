using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SimpleAPI.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("ok from Get()");
        }
        public IHttpActionResult Get(int i)
        {
            return Ok($"ok from Get(int i) i={i}");
        }

    }
}