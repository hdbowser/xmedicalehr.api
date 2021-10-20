using System;
using System.Collections.Generic;
using System.Linq;
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
    public class EnfermedadesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public EnfermedadesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync([FromQuery] string filter, int top = 10)
        {
            var result = await _unitOfWork.EnfermedadRepository.FilterAsync(top, filter);
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var result = await _unitOfWork.EnfermedadRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Enfermedad model)
        {
            await _unitOfWork.EnfermedadRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, result.Errors);
            }

            return Ok(new { Id = model.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Enfermedad model)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var enfermedad = (Enfermedad) await _unitOfWork.EnfermedadRepository.FindByIdAsync(id);
            if (enfermedad == null)
            {
                return NotFound();
            }

            enfermedad.Catalogo = model.Catalogo;
            enfermedad.Codigo = model.Codigo;
            enfermedad.Descripcion = model.Descripcion;
            enfermedad.Keywords = model.Keywords;
            
            _unitOfWork.EnfermedadRepository.Update(enfermedad);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(string id, bool disable = true)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var enfermedad = (Enfermedad) await _unitOfWork.EnfermedadRepository.FindByIdAsync(id);
            if (enfermedad == null)
            {
                return NotFound();
            }
            
            _unitOfWork.EnfermedadRepository.Delete(enfermedad, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}