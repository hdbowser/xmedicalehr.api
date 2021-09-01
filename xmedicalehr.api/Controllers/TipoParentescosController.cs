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
    public class TipoParentescosController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public TipoParentescosController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.TipoParentescoRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.TipoParentescoRepository.FindByIdAsync(id);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] TipoParentesco model)
        {
            await _unitOfWork.TipoParentescoRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return Ok(new { model.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] TipoParentesco model)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var tipo = (TipoParentesco) await _unitOfWork.TipoParentescoRepository.FindByIdAsync(id);
            if (tipo == null)
            {
                return NotFound();
            }

            tipo.Descripcion = model.Descripcion;

            _unitOfWork.TipoParentescoRepository.Update(tipo);
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
            if (id == null)
            {
                return BadRequest();
            }

            var tipo = (TipoParentesco) await _unitOfWork.TipoParentescoRepository.FindByIdAsync(id);
            if(tipo == null)
            {
                return NotFound();
            }

            _unitOfWork.TipoParentescoRepository.Delete(tipo, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return NoContent();
        }
        
        
        
    }
}