using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Account;
using xmedicalehr.api.Core.Utilities;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models.ViewModels;
//using xmedicalehr.api.Models;

namespace xmedicalehr.api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly TokenGenerator _token;
        private readonly UnitOfWork _unitOfWork;
        private readonly RoleManager<Role> _role;


        public UsersController(AppDbContext dbContext, IConfiguration configuration, UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<Role> role)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _token = new TokenGenerator(configuration);
            _unitOfWork = new UnitOfWork(dbContext, configuration);
            _role = role;
        }


        [HttpPost("LogIn")]
        public async Task<ActionResult> LogIn([FromBody] UserCredentialViewModel model)
        {
            if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest();
            }

            var user = await _userManager.FindByEmailAsync(model.UserName);
            if (user == null)
            {
                return NotFound();
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
            if (!result.Succeeded)
            {
                return new JsonResult("Contraseña invalida");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var claims = await _userManager.GetClaimsAsync(user);

            foreach (var item in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, item));
            }
            claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
            claims.Add(new Claim(ClaimTypes.Actor, user.Name));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            return new JsonResult(_token.CreateToken(user, claims));
        }
        
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] RegisterUserViewModel model)
        {
            if(model == null)
            {
                return BadRequest();
            }

            if (!model.Password.Equals(model.ConfirmPassword))
            {
                return BadRequest(new { Message = "La contraseña no coincide" });
            }

            var user = new User
            {
                Prefix = model.Prefix,
                Name = $"{model.Nombres} {model.Apellidos}",
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.Telefono
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                return StatusCode(500, result.Errors);
            }

            var roleAdded = await _userManager.AddToRoleAsync(user, "user");

            return Ok(new { user.Id });
        }
    }
}