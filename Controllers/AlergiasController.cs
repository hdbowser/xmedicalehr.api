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
    public class AlergiasController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public AlergiasController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.AlergiaRepository.FilterAsync();

            return new JsonResult(result);
        }

        [HttpGet("{pacienteId}/{sustanciaId}")]
        public async Task<IActionResult> GetAsync(string pacienteId, string sustanciaId)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrEmpty(sustanciaId) || 
                string.IsNullOrWhiteSpace(pacienteId) || 
                string.IsNullOrWhiteSpace(sustanciaId))
            {
                return BadRequest();
            }
            
            var alergia = await _unitOfWork.AlergiaRepository.FindByIdAsync(pacienteId, sustanciaId);
            return new JsonResult(alergia);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] AlergiaPaciente model)
        {
            await _unitOfWork.AlergiaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return Ok();
        }

        [HttpPut("{pacienteId}/{sustanciaId}")]
        public async Task<IActionResult> PutAsync(string pacienteId, string sustanciaId, [FromBody] AlergiaPaciente model)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrEmpty(sustanciaId) || 
                string.IsNullOrWhiteSpace(pacienteId) || 
                string.IsNullOrWhiteSpace(sustanciaId))
            {
                return BadRequest();
            }

            var alergia = (AlergiaPaciente) await _unitOfWork.AlergiaRepository.FindByIdAsync(pacienteId, sustanciaId);
            if(alergia == null)
            {
                return NotFound();
            }

            alergia.Comentario = model.Comentario;
            _unitOfWork.AlergiaRepository.Update(alergia);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return new JsonResult("Done");
        }
        [HttpDelete("{pacienteId}/{sustanciaId}")]
        public async Task<ActionResult> DeleteAsync(string pacienteId, string sustanciaId, bool disable = true)
        {
            if (string.IsNullOrEmpty(pacienteId) || 
                string.IsNullOrEmpty(sustanciaId) || 
                string.IsNullOrWhiteSpace(pacienteId) || 
                string.IsNullOrWhiteSpace(sustanciaId))
            {
                return BadRequest();
            }

            var alergia = (AlergiaPaciente) await _unitOfWork.AlergiaRepository.FindByIdAsync(pacienteId, sustanciaId);
            _unitOfWork.AlergiaRepository.Delete(alergia);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return new JsonResult("Done");
        }
        
    }
}