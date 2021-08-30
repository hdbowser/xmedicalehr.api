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
    public class SolicitudesInterconsultaController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public SolicitudesInterconsultaController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.SolicitudesInterconsultasRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{atencionId}/{numItem}")]
        public async Task<ActionResult> GetAsync(string atencionId, int numItem)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrWhiteSpace(atencionId) || numItem == 0)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.SolicitudesInterconsultasRepository.FindByIdAsync(atencionId, numItem);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] SolicitudInterconsulta model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.SolicitudesInterconsultasRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok();
        }

        [HttpPut("{atencionId}/{numItem}")]
        public async Task<IActionResult> PutAsync(string atencionId, int numItem, [FromBody] SolicitudInterconsulta model)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrWhiteSpace(atencionId) || numItem == 0)
            {
                return BadRequest();
            }

            var solicitud = (SolicitudInterconsulta) await _unitOfWork.SolicitudesInterconsultasRepository.FindByIdAsync(atencionId, numItem);
            if (solicitud == null )
            {
                return NotFound();
            }

            // solicitud.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            solicitud.DepartamentoId = model.DepartamentoId;
            solicitud.MedicoInterconsultadoId = model.MedicoInterconsultadoId;
            solicitud.Motivo = model.Motivo;
            solicitud.Recomendaciones = model.Recomendaciones;
            solicitud.Atendido = model.Atendido;

            
            _unitOfWork.SolicitudesInterconsultasRepository.Update(solicitud);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{atencionId}/{numItem}")]
        public async Task<ActionResult> DeleteAsync(string atencionId, int numItem, bool disable = true)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrWhiteSpace(atencionId) || numItem == 0)
            {
                return BadRequest();
            }

            var solicitud = (SolicitudInterconsulta) await _unitOfWork.SolicitudesInterconsultasRepository.FindByIdAsync(atencionId, numItem);
            if (solicitud == null )
            {
                return NotFound();
            }

            // solicitud.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            _unitOfWork.SolicitudesInterconsultasRepository.Delete(solicitud, disable);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}