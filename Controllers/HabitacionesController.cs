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
    public class HabitacionesController : ControllerBase
    {
        private readonly UnitOfWork _unitOfWork;

        public HabitacionesController(AppDbContext dbContext, IConfiguration configuration)
        {
            _unitOfWork = new UnitOfWork(dbContext, configuration);
        }


        [HttpGet("")]
        public async Task<ActionResult> GetAsync()
        {
            var result = await _unitOfWork.HabitacionRepository.FilterAsync();
            return new JsonResult(result);
        }


        [HttpPost("")]
        public async Task<ActionResult> PostAsync([FromBody] Habitacion model)
        {
            await _unitOfWork.HabitacionRepository.AddAsync(model);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }

            return Ok(new { model.Id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(string id, [FromBody] Habitacion model)
        {
            var hab = (Habitacion) await _unitOfWork.HabitacionRepository.FindByIdAsync(id);
            if (hab == null)
            {
                return NotFound();
            }

            hab.Descripcion = model.Descripcion;

            _unitOfWork.HabitacionRepository.Update(hab);
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

            var hab = (Habitacion) await _unitOfWork.HabitacionRepository.FindByIdAsync(id);
            if (hab == null)
            {
                return NotFound();
            }

            _unitOfWork.HabitacionRepository.Delete(hab, disable);
            var result = await _unitOfWork.SaveAsync();
            if (!result.Succeed)
            {
                return StatusCode(500, new { result.Errors });
            }
        
            return NoContent();
        }
        
        
    }
}