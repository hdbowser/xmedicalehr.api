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
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.OrdenMedicaRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{notaMedicaId}/{numItem}")]
        public async Task<ActionResult> GetAsync(string notaMedicaId, int numItem)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || string.IsNullOrWhiteSpace(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.OrdenMedicaRepository.FindByIdAsync(notaMedicaId, numItem);
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

        [HttpPut("{notaMedicaId}/{numItem}")]
        public async Task<IActionResult> PutAsync(string notaMedicaId, int numItem, [FromBody] OrdenMedica model)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || string.IsNullOrWhiteSpace(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var orden = (OrdenMedica) await _unitOfWork.OrdenMedicaRepository.FindByIdAsync(notaMedicaId, numItem);
            if (orden == null )
            {
                return NotFound();
            }

            // orden.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            orden.TipoId = model.TipoId;
            orden.MedicamentoId = model.MedicamentoId;
            orden.Unidad = model.Unidad;
            orden.Cantiad = model.Cantiad;
            orden.Via = model.Via;
            orden.Intervalo = model.Intervalo;
            orden.Tiempo = model.Tiempo;
            orden.Monodosis = model.Monodosis;
            orden.NumDiagnostico = model.NumDiagnostico;
            orden.TiempoExpiracion = model.TiempoExpiracion;
            orden.Suspendido = model.Suspendido;
            orden.EstudioId = model.EstudioId;
            orden.Fecha = model.Fecha;
            orden.Instruccciones = model.Instruccciones;
            orden.Comentario = model.Comentario;
            
            _unitOfWork.OrdenMedicaRepository.Update(orden);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{notaMedicaId}/{numItem}")]
        public async Task<ActionResult> DeleteAsync(string notaMedicaId, int numItem, bool disable = true)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || string.IsNullOrWhiteSpace(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var orden = (OrdenMedica) await _unitOfWork.OrdenMedicaRepository.FindByIdAsync(notaMedicaId, numItem);
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