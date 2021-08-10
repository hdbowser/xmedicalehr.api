using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using xmedicalehr.api.Models;

namespace xmedicalehr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController()
        {
        }

        [HttpGet("")]
        public async Task<ActionResult> GetTModels()
        {
            // TODO: Your code here
            await Task.Yield();

            return new JsonResult("");
        }
    }
}