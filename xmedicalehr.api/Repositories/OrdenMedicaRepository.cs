using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Core;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Repositories
{
    public class OrdenMedicaRepository : Repository
    {
        public OrdenMedicaRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(OrdenMedica model)
        {
            try
            {
                int num = 0;
                var numItems = await _db.OrdenesMedica.Where(x => x.AntencionId.Equals(model.AntencionId) && x.NotaMedicaId.Equals(model.NotaMedicaId)).Select(x => x.NumItem).ToListAsync();
                if(numItems.Count > 0)
                {
                    num = numItems.Max();
                }
                model.NumItem = (num > 0) ? ++num : 1;
                model.CreatedAt = DateTime.Now;

                await _db.OrdenesMedica.AddAsync(model);
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if (ex.InnerException != null)
                {
                    _log.Error(ex.InnerException.Message);
                }
                else
                {
                    _log.Error(ex.InnerException.Message);
                }
            }
        }

        public void Update(OrdenMedica model)
        {
            try
            {
                model.UpdatedAt = DateTime.Now;
                _db.OrdenesMedica.Update(model);
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if (ex.InnerException != null)
                {
                    _log.Error(ex.InnerException.Message);
                }
                else
                {
                    _log.Error(ex.InnerException.Message);
                }
            }
        }

        public async Task<List<object>> FilterAsync(string notaMedicaId = "")
        {
            var objList = new List<object>();
            try
            {
                objList = await _db.OrdenesMedica
                    .Include(x => x.AntencionMedica)
                    .Include(x => x.NotaMedica)
                    .Include(x => x.Medicamento)
                    .Include(x => x.Estudio)
                    .Include(x => x.Enfermedad)
                    .Where(x => !x.Deleted && x.NotaMedicaId.Equals(notaMedicaId))
                    .Select(x => new {
                        x.AntencionId,
                        x.NotaMedicaId,
                        x.NumItem,
                        x.Tipo,
                        x.MedicamentoId,
                        NombreMedicamento = x.Medicamento.Descripcion,
                        x.UnidadDosis,
                        x.CantidadDosis,
                        x.Via,
                        x.Intervalo,
                        x.Tiempo,
                        x.Monodosis,
                        Diagnostico = x.Enfermedad.Descripcion,
                        x.TiempoExpiracion,
                        x.Suspendido,
                        x.EstudioId,
                        NombreEstudio = x.Estudio.Descripcion,
                        x.Fecha,
                        x.Instrucciones,
                        x.Comentario
                    })
                    .Cast<object>()
                    .ToListAsync();
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if (ex.InnerException != null)
                {
                    _log.Error(ex.InnerException.Message);
                }
                else
                {
                    _log.Error(ex.InnerException.Message);
                }
            }
            return objList;
        }

        public async Task<object> FindByIdAsync(string atencionId, string notaMedicaId, int numItem)
        {
            object obj = null;
            try
            {
                obj = await _db.OrdenesMedica.FindAsync(atencionId, notaMedicaId, numItem);
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if (ex.InnerException != null)
                {
                    _log.Error(ex.InnerException.Message);
                }
                else
                {
                    _log.Error(ex.InnerException.Message);
                }
            }
            return obj;
        }

        public void Delete(OrdenMedica model, bool disable = true)
        {
            try
            {
                if (disable)
                {
                    model.Deleted = true;
                    model.DeletedAt = DateTime.Now;
                    _db.OrdenesMedica.Update(model);
                }
                else
                {
                    _db.OrdenesMedica.Remove(model);
                }
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if (ex.InnerException != null)
                {
                    _log.Error(ex.InnerException.Message);
                }
                else
                {
                    _log.Error(ex.InnerException.Message);
                }
            }
        }
    }
}