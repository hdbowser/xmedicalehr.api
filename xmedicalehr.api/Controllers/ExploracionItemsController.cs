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
    public class ExploracionItemsController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public ExploracionItemsController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }

        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.ExploracionItemRepository.FilterAsync() ;
            return new JsonResult(result);
        }

        [HttpGet("{notaMedicaId}/{exploracionItemTemplateId}")]
        public async Task<ActionResult> GetAsync(string notaMedicaId, string exploracionItemTemplateId)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || 
                string.IsNullOrWhiteSpace(notaMedicaId) ||
                string.IsNullOrEmpty(exploracionItemTemplateId) || 
                string.IsNullOrWhiteSpace(exploracionItemTemplateId))
            {
                return BadRequest();
            }

            var result = await _unitOfWork.ExploracionItemRepository.FindByIdAsync(notaMedicaId, exploracionItemTemplateId);
            return new JsonResult(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] ExploracionItem model)
        {
            await _unitOfWork.ExploracionItemRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, result.Errors);
            }

            return Ok();
        }

        [HttpPut("{notaMedicaId}/{exploracionItemTemplateId}")]
        public async Task<IActionResult> PutAsync(string notaMedicaId, string exploracionItemTemplateId, [FromBody] ExploracionItem model)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || 
                string.IsNullOrWhiteSpace(notaMedicaId) ||
                string.IsNullOrEmpty(exploracionItemTemplateId) || 
                string.IsNullOrWhiteSpace(exploracionItemTemplateId))
            {
                return BadRequest();
            }

            var item = (ExploracionItem) await _unitOfWork.ExploracionItemRepository.FindByIdAsync(notaMedicaId, exploracionItemTemplateId);
            if (item == null)
            {
                return NotFound();
            }

            item.Descripcion = model.Descripcion;
            
            _unitOfWork.ExploracionItemRepository.Update(item);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }

        [HttpDelete("{notaMedicaId}/{exploracionItemTemplateId}")]
        public async Task<ActionResult> DeleteAsync(string notaMedicaId, string exploracionItemTemplateId, bool disable = true)
        {
            if (string.IsNullOrEmpty(notaMedicaId) || 
                string.IsNullOrWhiteSpace(notaMedicaId) ||
                string.IsNullOrEmpty(exploracionItemTemplateId) || 
                string.IsNullOrWhiteSpace(exploracionItemTemplateId))
            {
                return BadRequest();
            }

            var item = (ExploracionItem) await _unitOfWork.ExploracionItemRepository.FindByIdAsync(notaMedicaId, exploracionItemTemplateId);
            if (item == null)
            {
                return NotFound();
            }
            
            _unitOfWork.ExploracionItemRepository.Delete(item, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
            return NoContent();
        }
    }
}