using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHARP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CsharpController : ControllerBase
    {
        public CsharpController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
