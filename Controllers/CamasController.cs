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
    public class CamasController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public CamasController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.CamaRepository.FilterAsync();

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.CamaRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Cama model)
        {
            await _unitOfWork.CamaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return Ok(model.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Cama model)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var cama = (Cama) await _unitOfWork.CamaRepository.FindByIdAsync(id);
            if (cama == null)
            {
                return NotFound();
            }

            cama.Descripcion = model.Descripcion;
            _unitOfWork.CamaRepository.Update(cama);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return new JsonResult("Done");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id, bool disable = true)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var cama = (Cama) await _unitOfWork.CamaRepository.FindByIdAsync(id);
            if(cama == null)
            {
                return NotFound();
            }

            _unitOfWork.CamaRepository.Delete(cama);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return new JsonResult("Done");
        }
        
        
        
    }
}