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
    public class DepartamentosController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public DepartamentosController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.DepartamentoRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var result = await _unitOfWork.DepartamentoRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Departamento model)
        {
            await _unitOfWork.DepartamentoRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, result.Errors);
            }

            return Ok(new { Id = model.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Departamento model)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var depto = (Departamento) await _unitOfWork.DepartamentoRepository.FindByIdAsync(id);
            if (depto == null)
            {
                return NotFound();
            }

            depto.Descripcion = model.Descripcion;
            
            _unitOfWork.DepartamentoRepository.Update(depto);
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
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var depto = (Departamento) await _unitOfWork.DepartamentoRepository.FindByIdAsync(id);
            if (depto == null)
            {
                return NotFound();
            }
            
            _unitOfWork.DepartamentoRepository.Delete(depto, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}