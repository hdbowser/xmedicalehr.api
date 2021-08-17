using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using xmedicalehr.api.Account;
using xmedicalehr.api.Models;
using xmedicalehr.api.Models.ViewModels;

namespace xmedicalehr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<Role> _roleManager;

        public RolesController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }


        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] RoleViewModel model)
        {
            var roleExists = await _roleManager.FindByNameAsync(model.Name);
            if(roleExists != null)
            {
                return StatusCode(500, new { Message = "El Role ya existe" });
            }

            var role = new Role
            {
                Name = model.Name,
                DisplayName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(model.Name),
                NormalizedName = model.Name.ToUpper()
            };

            var result = await _roleManager.CreateAsync(role);
            if (!result.Succeeded)
            {
                return StatusCode(500, result.Errors);
            }

            return Ok(role.Id);
        }
    }
}