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
    public class TipoAtencionesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public TipoAtencionesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.TipoAtencionRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var TipoAtencion = await _unitOfWork.TipoAtencionRepository.FindByIdAsync(id);
            return new JsonResult(TipoAtencion);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] TipoAtencion model)
        {
            await _unitOfWork.TipoAtencionRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok(new { model.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] TipoAtencion model)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var tipo = (TipoAtencion) await _unitOfWork.TipoAtencionRepository.FindByIdAsync(id);
            if (tipo == null)
            {
                return NotFound();
            }

            tipo.Descripcion = model.Descripcion;

            _unitOfWork.TipoAtencionRepository.Update(tipo);
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

            var tipo = (TipoAtencion) await _unitOfWork.TipoAtencionRepository.FindByIdAsync(id);
            if (tipo == null)
            {
                return NotFound();
            }

            _unitOfWork.TipoAtencionRepository.Delete(tipo, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}