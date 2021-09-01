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
    public class MedicacionesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public MedicacionesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.MedicacionRepository.FilterAsync();
            return new JsonResult(result);
        }

        [HttpGet("{atencionId}/{numItem}")]
        public async Task<ActionResult> GetAsync(string atencionId, int numItem)
        {
            if (string.IsNullOrEmpty(atencionId) || 
                string.IsNullOrWhiteSpace(atencionId) ||
                numItem == 0)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.MedicacionRepository.FindByIdAsync(atencionId, numItem);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Medicacion model)
        {
            await _unitOfWork.MedicacionRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, result.Errors);
            }

            return Ok();
        }

        [HttpPut("{atencionId}/{numItem}")]
        public async Task<IActionResult> PutAsync(string atencionId, int numItem, [FromBody] Medicacion model)
        {
            if (string.IsNullOrEmpty(atencionId) || 
                string.IsNullOrWhiteSpace(atencionId) ||
                numItem == 0)
            {
                return BadRequest();
            }

            var medicacion = (Medicacion) await _unitOfWork.MedicacionRepository.FindByIdAsync(atencionId, numItem);
            if (medicacion == null)
            {
                return NotFound();
            }

            
            
            _unitOfWork.MedicacionRepository.Update(medicacion);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{atencionId}/{numItem}")]
        public async Task<ActionResult> DeleteAsync(string atencionId, int numItem, bool disable = true)
        {
            if (string.IsNullOrEmpty(atencionId) || 
                string.IsNullOrWhiteSpace(atencionId) ||
                numItem == 0)
            {
                return BadRequest();
            }

            var medicacion = (Medicacion) await _unitOfWork.MedicacionRepository.FindByIdAsync(atencionId, numItem);
            if (medicacion == null)
            {
                return NotFound();
            }
            
            _unitOfWork.MedicacionRepository.Delete(medicacion, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}