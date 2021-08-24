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
    public class ProvinciasController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public ProvinciasController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.ProvinciaRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(string id)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var Provincia = await _unitOfWork.ProvinciaRepository.FindByIdAsync(id);
            return new JsonResult(Provincia);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Provincia model)
        {
            await _unitOfWork.ProvinciaRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok(new { model.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Provincia model)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id))
            {
                return BadRequest();
            }

            var Provincia = (Provincia) await _unitOfWork.ProvinciaRepository.FindByIdAsync(id);
            if (Provincia == null)
            {
                return NotFound();
            }

            Provincia.Nombre = model.Nombre;
            Provincia.CodigoInt = model.CodigoInt;

            _unitOfWork.ProvinciaRepository.Update(Provincia);
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

            var Provincia = (Provincia) await _unitOfWork.ProvinciaRepository.FindByIdAsync(id);
            if (Provincia == null)
            {
                return NotFound();
            }

            _unitOfWork.ProvinciaRepository.Delete(Provincia, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}