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
    public class NotasMedicasCustomFieldController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public NotasMedicasCustomFieldController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.NotaMedicaCustomFieldRepository.FilterAsync();
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

            var result = await _unitOfWork.NotaMedicaCustomFieldRepository.FindByIdAsync(atencionId, numItem);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] NotaMedicaCustomField model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.NotaMedicaCustomFieldRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, result.Errors);
            }

            return Ok();
        }

        [HttpPut("{atencionId}/{numItem}")]
        public async Task<IActionResult> PutAsync(string atencionId, int numItem, [FromBody] NotaMedicaCustomField model)
        {
            if (string.IsNullOrEmpty(atencionId) || 
                string.IsNullOrWhiteSpace(atencionId) ||
                numItem == 0)
            {
                return BadRequest();
            }
            
            var nota = (NotaMedicaCustomField) await _unitOfWork.NotaMedicaCustomFieldRepository.FindByIdAsync(atencionId, numItem);
            if (nota == null)
            {
                return NotFound();
            }

            nota.Titulo = model.Titulo;
            nota.Valor = model.Valor;
            
            _unitOfWork.NotaMedicaCustomFieldRepository.Update(nota);
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

            var nota = (NotaMedicaCustomField) await _unitOfWork.NotaMedicaCustomFieldRepository.FindByIdAsync(atencionId, numItem);
            if (nota == null)
            {
                return NotFound();
            }
            
            _unitOfWork.NotaMedicaCustomFieldRepository.Delete(nota, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}