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
    public class PacientesParentescoController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public PacientesParentescoController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.PacienteParentescoRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{pacienteId}/{parentescoId}/{tipoParentescoId}")]
        public async Task<ActionResult> GetAsync(string pacienteId, string parentescoId, string tipoParentescoId)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrWhiteSpace(pacienteId) ||
                string.IsNullOrEmpty(tipoParentescoId) || 
                string.IsNullOrWhiteSpace(tipoParentescoId))
            {
                return BadRequest();
            }

            var result = await _unitOfWork.PacienteParentescoRepository.FindByIdAsync(pacienteId, parentescoId, tipoParentescoId);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] PacienteParentesco model)
        {
            await _unitOfWork.PacienteParentescoRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, result.Errors);
            }

            return Ok();
        }

        [HttpPut("{pacienteId}/{parentescoId}/{tipoParentescoId}")]
        public async Task<IActionResult> PutAsync(string pacienteId, string parentescoId, string tipoParentescoId, [FromBody] PacienteParentesco model)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrWhiteSpace(pacienteId) ||
                string.IsNullOrEmpty(tipoParentescoId) || 
                string.IsNullOrWhiteSpace(tipoParentescoId))
            {
                return BadRequest();
            }

            var parentesco = (PacienteParentesco) await _unitOfWork.PacienteParentescoRepository.FindByIdAsync(pacienteId, parentescoId, tipoParentescoId);
            if (parentesco == null)
            {
                return NotFound();
            }

            parentesco.Comentario = model.Comentario;
            
            _unitOfWork.PacienteParentescoRepository.Update(parentesco);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{pacienteId}/{parentescoId}/{tipoParentescoId}")]
        public async Task<ActionResult> DeleteAsync(string pacienteId, string parentescoId, string tipoParentescoId, bool disable = true)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrWhiteSpace(pacienteId) ||
                string.IsNullOrEmpty(tipoParentescoId) || 
                string.IsNullOrWhiteSpace(tipoParentescoId))
            {
                return BadRequest();
            }

            var parentesco = (PacienteParentesco) await _unitOfWork.PacienteParentescoRepository.FindByIdAsync(pacienteId, parentescoId, tipoParentescoId);
            if (parentesco == null)
            {
                return NotFound();
            }
            
            _unitOfWork.PacienteParentescoRepository.Delete(parentesco, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}