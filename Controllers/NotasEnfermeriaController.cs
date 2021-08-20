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
    public class NotasEnfermeriaController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public NotasEnfermeriaController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync([FromQuery] NotaEnfermeriaFilter filter)
        {
            var result = await _unitOfWork.NotaEnfermeriaRepository.FilterAsync(filter);
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var result = await _unitOfWork.NotaEnfermeriaRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] NotaEnfermeria model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.NotaEnfermeriaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok(model.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] NotaEnfermeria model)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var nota = (NotaEnfermeria) await _unitOfWork.NotaEnfermeriaRepository.FindByIdAsync(id);
            if (nota == null)
            {
                return NotFound();
            }

            // nota.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            nota.AtencionId = model.AtencionId;
            nota.HabitusExterior = model.HabitusExterior;
            nota.Observaciones = model.Observaciones;
            nota.EnfermeraId = model.EnfermeraId;
            nota.Fecha = model.Fecha;

            _unitOfWork.NotaEnfermeriaRepository.Update(nota);
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
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var nota = (NotaEnfermeria) await _unitOfWork.NotaEnfermeriaRepository.FindByIdAsync(id);
            if (nota == null)
            {
                return NotFound();
            }

            // nota.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _unitOfWork.NotaEnfermeriaRepository.Delete(nota);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return new JsonResult("Done");
        }
    }
}