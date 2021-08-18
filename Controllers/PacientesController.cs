using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;
//using xmedicalehr.api.Models;

namespace xmedicalehr.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public PacientesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.PacienteRepository.FilterAsync();

            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Paciente model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.PacienteRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return new JsonResult(model.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Paciente model)
        {
            var paciente = (Paciente) await _unitOfWork.PacienteRepository.FindByIdAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            
            // paciente.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            paciente.Nombres = model.Nombres;
            paciente.PrimerApellido = model.PrimerApellido;
            paciente.EstadoCivil = model.EstadoCivil;
            paciente.Sexo = model.Sexo;
            paciente.FechaNacimiento = model.FechaNacimiento;
            paciente.Cedula = model.Cedula;
            paciente.Email = model.Email;
            paciente.Celular = model.Celular;
            paciente.Telefono = model.Telefono;
            paciente.Direccion = model.Direccion;
            paciente.Nota = model.Nota;
            paciente.NSS = model.NSS;
            paciente.NumAsegurado = model.NumAsegurado;
            paciente.Estatura = model.Estatura;
            paciente.UnidadEstatura = model.UnidadEstatura;
            paciente.Ciudad = model.Ciudad;
            paciente.ProvinciaId = model.ProvinciaId;
            paciente.NacionalidadId = model.NacionalidadId;
            paciente.AseguradoraId = model.AseguradoraId;

            _unitOfWork.PacienteRepository.Update(paciente);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return new JsonResult("Done");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id)
        {
            var paciente = (Paciente) await _unitOfWork.PacienteRepository.FindByIdAsync(id);
            if(paciente == null)
            {
                return NotFound();
            }

            // paciente.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _unitOfWork.PacienteRepository.Delete(paciente);
            var result = await _unitOfWork.SaveAsync();
            if (result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return new JsonResult("Done");
        }
        
        
    }
}