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
    public class NotasMedicasController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public NotasMedicasController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync([FromQuery] NotaMedicaFilter filter)
        {
            var result = await _unitOfWork.NotaMedicaRepository.FilterAsync(filter);
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NotaMedica>> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var result = await _unitOfWork.NotaMedicaRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult<NotaMedica>> PostAsync([FromBody] NotaMedica model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.NotaMedicaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok(model.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] NotaMedica model)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var nota = (NotaMedica) await _unitOfWork.NotaMedicaRepository.FindByIdAsync(id);
            if (nota == null)
            {
                return NotFound();
            }

            // nota.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            nota.Id = model.Id;
            nota.AtencionId = model.AtencionId;
            nota.MotivoConsulta = model.MotivoConsulta;
            nota.HistoriaEnfermedad = model.HistoriaEnfermedad;
            nota.Nota = model.Nota;
            nota.TipoNotaId = model.TipoNotaId;
            nota.DeOrden = model.DeOrden;
            nota.Dieta = model.Dieta;
            nota.ExamenFisico = model.ExamenFisico;
            nota.Observaciones = model.Observaciones;
            nota.MedicoId = model.MedicoId;
            nota.MotivoEgreso = model.MotivoEgreso;
            nota.Pronostico = model.Pronostico;
            nota.Fecha = model.Fecha;
            nota.Peso = model.Peso;
            nota.UnidadPeso = model.UnidadPeso;
            nota.EscalaGlasgow = model.EscalaGlasgow;
            nota.EscalaDolor = model.EscalaDolor;
            nota.SaturacionOxigeno = model.SaturacionOxigeno;
            nota.OtrosParametros = model.OtrosParametros;

            _unitOfWork.NotaMedicaRepository.Update(nota);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return new JsonResult("Done");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<NotaMedica>> DeleteAsync(string id, bool disable = true)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var nota = (NotaMedica) await _unitOfWork.NotaMedicaRepository.FindByIdAsync(id);
            if(nota == null)
            {
                return NotFound();
            }

            nota.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _unitOfWork.NotaMedicaRepository.Delete(nota);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return null;
        }
    }
}