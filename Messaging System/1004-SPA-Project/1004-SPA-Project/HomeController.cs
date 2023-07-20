using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1004_SPA_Project
{
    public class HomeController : Controller
    {
        [ApiController]
        [Route("api/[controller]")]
        public class YourControllerNameController : ControllerBase
        {
            [HttpGet("data")]
            public ActionResult<IEnumerable<string>> GetData()
            {
                // Replace this with your actual data retrieval logic
                var data = new List<string> { "Data 1", "Data 2", "Data 3" };
                return Ok(data);
            }
        }
    }
}
