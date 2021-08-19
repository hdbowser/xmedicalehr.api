using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AseguradorasController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public AseguradorasController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.AseguradoraRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var result = await _unitOfWork.AseguradoraRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Aseguradora model)
        {
            await _unitOfWork.AseguradoraRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok(model.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Aseguradora model)
        {
            // TODO: Your code here
            await Task.Yield();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id, bool disable = true)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }
    }
}