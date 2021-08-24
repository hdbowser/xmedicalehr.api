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
    public class DiagnosticosController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public DiagnosticosController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync([FromQuery] DiagnosticoFilter filter)
        {
            var result = await _unitOfWork.DiagnosticoRepository.FilterAsync(filter);
            return new JsonResult(result);
        }

        [HttpGet("{notaMedicaId}/{numItem}")]
        public async Task<ActionResult> GetAsync(string notaMedicaId, int numItem)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || string.IsNullOrWhiteSpace(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.DiagnosticoRepository.FindByIdAsync(notaMedicaId, numItem);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Diagnostico model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.DiagnosticoRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok();
        }

        [HttpPut("{notaMedicaId}/{numItem}")]
        public async Task<IActionResult> PutAsync(string notaMedicaId, int numItem, [FromBody] Diagnostico model)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || string.IsNullOrWhiteSpace(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var diag = (Diagnostico) await _unitOfWork.DiagnosticoRepository.FindByIdAsync(notaMedicaId, numItem);
            if (diag == null )
            {
                return NotFound();
            }

            // diag.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            diag.NotaMedicaId = model.NotaMedicaId;
            diag.NumItem = model.NumItem;
            diag.EnfermedadId = model.EnfermedadId;
            diag.Comentario = model.Comentario;

            _unitOfWork.DiagnosticoRepository.Update(diag);
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

            var diag = (Diagnostico) await _unitOfWork.DiagnosticoRepository.FindByIdAsync(notaMedicaId, numItem);
            if (diag == null )
            {
                return NotFound();
            }

            _unitOfWork.DiagnosticoRepository.Delete(diag, disable);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}