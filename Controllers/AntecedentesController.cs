using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Core.FilterClass;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AntecedentesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public AntecedentesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync([FromQuery] AntecedenteFilter filter)
        {
            var result = await _unitOfWork.AntecedentePacienteRepository.FilterAsync(filter);
            return new JsonResult(result);
        }

        [HttpGet("{pacienteId}/{tipoAntecedenteId}")]
        public async Task<ActionResult> GetAsync(string pacienteId, string tipoAntecedenteId)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrWhiteSpace(pacienteId) ||
                string.IsNullOrEmpty(tipoAntecedenteId) || 
                string.IsNullOrWhiteSpace(tipoAntecedenteId)
            )
            {
                return BadRequest();
            }

            var antecedente = await _unitOfWork.AntecedentePacienteRepository.FindByIdAsync(pacienteId, tipoAntecedenteId);
            return new JsonResult(antecedente);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] AntecedentePaciente model)
        {
            model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.AntecedentePacienteRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok();
        }

        [HttpPut("{pacienteId}/{tipoAntecedenteId}")]
        public async Task<IActionResult> PutAsync(string pacienteId, string tipoAntecedenteId, [FromBody] AntecedentePaciente model)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrWhiteSpace(pacienteId) ||
                string.IsNullOrEmpty(tipoAntecedenteId) || 
                string.IsNullOrWhiteSpace(tipoAntecedenteId)
            )
            {
                return BadRequest();
            }

            var antecedente = (AntecedentePaciente) await _unitOfWork.AntecedentePacienteRepository.FindByIdAsync(pacienteId, tipoAntecedenteId);
            if (antecedente == null)
            {
                return NotFound();
            }

            antecedente.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            antecedente.Detalle = model.Detalle;

            _unitOfWork.AntecedentePacienteRepository.Update(antecedente);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return new JsonResult("Done");
        }

        [HttpDelete("{pacienteId}/{tipoAntecedenteId}")]
        public async Task<ActionResult> DeleteAsync(string pacienteId, string tipoAntecedenteId, bool disable = true)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrWhiteSpace(pacienteId) ||
                string.IsNullOrEmpty(tipoAntecedenteId) || 
                string.IsNullOrWhiteSpace(tipoAntecedenteId)
            )
            {
                return BadRequest();
            }

            var antecedente = (AntecedentePaciente) await _unitOfWork.AntecedentePacienteRepository.FindByIdAsync(pacienteId, tipoAntecedenteId);
            if (antecedente == null)
            {
                return NotFound();
            }

            antecedente.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            _unitOfWork.AntecedentePacienteRepository.Delete(antecedente);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return new JsonResult("Done");
        }
    }
}