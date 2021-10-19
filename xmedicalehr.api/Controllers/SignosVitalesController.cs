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
    public class SignosVitalesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public SignosVitalesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync([FromQuery] SignosVitalesFilter filter)
        {
            var result = await _unitOfWork.SignosVitalesRepository.FilterAsync(filter);
            return new JsonResult(result);
        }

        [HttpGet("{atencionId}/{notaMedicaId}/{numItem}")]
        public async Task<ActionResult> GetAsync(string atencionId, string notaMedicaId, int numItem)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrEmpty(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var result = await _unitOfWork.SignosVitalesRepository.FindByIdAsync(atencionId, notaMedicaId, numItem);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] SignosVitales model)
        {
            // model.CreatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _unitOfWork.SignosVitalesRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok();
        }

        [HttpPut("{atencionId}/{notaMedicaId}/{numItem}")]
        public async Task<IActionResult> PutAsync(string atencionId, string notaMedicaId, int numItem, [FromBody] SignosVitales model)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrEmpty(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var signoVital = (SignosVitales) await _unitOfWork.SignosVitalesRepository.FindByIdAsync(atencionId, notaMedicaId, numItem);
            if (signoVital == null )
            {
                return NotFound();
            }

            // signoVital.UpdatedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            signoVital.Origen = model.Origen;
            signoVital.Temperatura = model.Temperatura;
            signoVital.UnidadTemperatura = model.UnidadTemperatura;
            signoVital.FrecuenciaRespiratoria = model.FrecuenciaRespiratoria;
            signoVital.FrecuenciaCardiaca = model.FrecuenciaCardiaca;
            signoVital.PresionSistolica = model.PresionSistolica;
            signoVital.PresionDiastolica = model.PresionDiastolica;
            signoVital.Diuresis = model.Diuresis;
            
            _unitOfWork.SignosVitalesRepository.Update(signoVital);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{atencionId}/{notaMedicaId}/{numItem}")]
        public async Task<ActionResult> DeleteAsync(string atencionId, string notaMedicaId, int numItem, bool disable = true)
        {
            if (string.IsNullOrEmpty(atencionId) || string.IsNullOrEmpty(notaMedicaId) || numItem == 0)
            {
                return BadRequest();
            }

            var signoVital = (SignosVitales) await _unitOfWork.SignosVitalesRepository.FindByIdAsync(atencionId, notaMedicaId, numItem);
            if (signoVital == null )
            {
                return NotFound();
            }

            // signoVital.DeletedBy = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            _unitOfWork.SignosVitalesRepository.Delete(signoVital, disable);
            var result = await _unitOfWork.SaveAsync();
            if(!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}