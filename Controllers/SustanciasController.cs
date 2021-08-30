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
    public class SustanciasController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public SustanciasController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.SustanciaRepository.FilterAsync();

            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.SustanciaRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Sustancia model)
        {
            await _unitOfWork.SustanciaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return Ok(new { model.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Sustancia model)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var sustancia = (Sustancia) await _unitOfWork.SustanciaRepository.FindByIdAsync(id);
            if (sustancia == null)
            {
                return NotFound();
            }

            sustancia.Descripcion = model.Descripcion;
            _unitOfWork.SustanciaRepository.Update(sustancia);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id, bool disable = true)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var sustancia = (Sustancia) await _unitOfWork.SustanciaRepository.FindByIdAsync(id);
            if(sustancia == null)
            {
                return NotFound();
            }

            _unitOfWork.SustanciaRepository.Delete(sustancia, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return NoContent();
        }
        
        
        
    }
}