using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtencionesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public AtencionesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.AtencionMedicaRepository.FilterAsync();

            return new JsonResult(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.AtencionMedicaRepository.FindByIdAsync(id);

            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] AtencionMedica model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.AtencionMedicaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok(model.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] AtencionMedica model)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest();
            }

            var atencion = (AtencionMedica)await _unitOfWork.AtencionMedicaRepository.FindByIdAsync(id);
            if (atencion == null)
            {
                return NotFound();
            }

            // atencion.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            atencion.PacienteId = model.PacienteId;
            atencion.TipoId = model.TipoId;
            atencion.AseguradoraId = model.AseguradoraId;
            atencion.MedicoId = model.MedicoId;
            atencion.FechaIngreso = model.FechaIngreso;
            atencion.EdadPaciente = model.EdadPaciente;
            atencion.CamaId = model.CamaId;
            atencion.Origen = model.Origen;
            atencion.NombreFinanciador = model.NombreFinanciador;
            atencion.TipoFinanciamiento = model.TipoFinanciamiento;
            atencion.FirmaPaciente = model.FirmaPaciente;

            _unitOfWork.AtencionMedicaRepository.Update(atencion);
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
            
            var atencion = (AtencionMedica) await _unitOfWork.AtencionMedicaRepository.FindByIdAsync(id);
            if (atencion == null)
            {
                return NotFound();
            }

            // atencion.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _unitOfWork.AtencionMedicaRepository.Delete(atencion);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return new JsonResult("Done");
        }
        

    }
}