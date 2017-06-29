using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace spcs.Controllers
{
    [Route("api/[controller]")]
    public class PingController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { Assembly.GetEntryAssembly().GetName().Name, "Ping2", "GET", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ms ") });
        }
        
    }
}
