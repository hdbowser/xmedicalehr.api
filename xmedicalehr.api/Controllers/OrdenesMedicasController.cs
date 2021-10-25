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
    public class OrdenesMedicasController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public OrdenesMedicasController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync(string notaMedicaId)
        {
            var result = await _unitOfWork.OrdenMedicaRepository.FilterAsync(notaMedicaId);
            return new JsonResult(result);
        }

        [HttpGet("{atencionId}/{notaMedicaId}/{numItem}")]
        public async Task<ActionResult> GetAsync(string atencionId, string notaMedicaId, int numItem)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrEmpty(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.OrdenMedicaRepository.FindByIdAsync(atencionId, notaMedicaId, numItem);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] OrdenMedica model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.OrdenMedicaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok();
        }

        [HttpPut("{atencionId}/{notaMedicaId}/{numItem}")]
        public async Task<IActionResult> PutAsync(string atencionId, string notaMedicaId, int numItem, [FromBody] OrdenMedica model)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrEmpty(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var orden = (OrdenMedica) await _unitOfWork.OrdenMedicaRepository.FindByIdAsync(atencionId, notaMedicaId, numItem);
            if (orden == null )
            {
                return NotFound();
            }

            // orden.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            // orden.Tipo = model.Tipo;
            // orden.MedicamentoId = model.MedicamentoId;
            // orden.UnidadDosis = model.UnidadDosis;
            // orden.CantidadDosis = model.CantidadDosis;
            // orden.Via = model.Via;
            // orden.Intervalo = model.Intervalo;
            // orden.Tiempo = model.Tiempo;
            // orden.Monodosis = model.Monodosis;
            // orden.NumDiagnostico = model.NumDiagnostico;
            // orden.TiempoExpiracion = model.TiempoExpiracion;
            // orden.Suspendido = model.Suspendido;
            // orden.EstudioId = model.EstudioId;
            // orden.Fecha = model.Fecha;
            // orden.Instrucciones = model.Instrucciones;
            orden.Comentario = model.Comentario;
            
            _unitOfWork.OrdenMedicaRepository.Update(orden);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{atencionId}/{notaMedicaId}/{numItem}")]
        public async Task<ActionResult> DeleteAsync(string atencionId, string notaMedicaId, int numItem, bool disable = true)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrEmpty(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var orden = (OrdenMedica) await _unitOfWork.OrdenMedicaRepository.FindByIdAsync(atencionId, notaMedicaId, numItem);
            if (orden == null )
            {
                return NotFound();
            }

            // orden.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            _unitOfWork.OrdenMedicaRepository.Delete(orden, disable);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}