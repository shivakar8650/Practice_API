using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployController : ControllerBase
    {
        [HttpGet]
        [Route("name")]
        public IActionResult GetEmplyeeData()
        {
            List<string> empployeeData = new List<string>()
            {
                "shiva","naresh","vishal","ankit"
            };

            return this.Ok(new { success = true, message = "get data successfull", Data = empployeeData });
        }

        [HttpGet("Address")]
        public IActionResult GetEmpAddress()
        {
            List<string> employeeData = GetAddress();
            return this.Ok(new { success = true, message = "get data successfull", Data = employeeData });
        }

        private static List<string> GetAddress()
        {
            return new List<string>()
            {
                "delhi","haridwar","agra","mumbai"
            };
        }

        [HttpPost("{address}")]
        
        public IActionResult takeAddress(string address)
        {
            List<string> employData = new List<string>();
            employData.Add(address);
            return this.Ok(new { success = true, message = "get data successfully", Data = employData });
        }
    }
}
