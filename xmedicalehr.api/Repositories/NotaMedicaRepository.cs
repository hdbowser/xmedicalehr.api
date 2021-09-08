using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Core;
using xmedicalehr.api.Core.FilterClass;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;

namespace xmedicalehr.api.Repositories
{
    public class NotaMedicaRepository : Repository
    {
        public NotaMedicaRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(NotaMedica model)
        {
            try
            {
                model.Id = Guid.NewGuid().ToString();
                model.CreatedAt = DateTime.Now;
                await _db.NotasMedica.AddAsync(model);
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

        public void Update(NotaMedica model)
        {
            try
            {
                model.UpdatedAt = DateTime.Now;
                _db.NotasMedica.Update(model);
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

        public async Task<List<object>> FilterAsync(NotaMedicaFilter filter)
        {
            try
            {
                var objList = _db.NotasMedica
                    .Include(x => x.AtencionMedica)
                    .Include(x => x.TipoNota)
                    .Include(x => x.Medico)
                    .Where(x => !x.Deleted)
                    .Select(x => new{
                        x.Id,
                        x.AtencionId,
                        x.MedicoId,
                        NombreMedico = x.Medico.Name,
                        x.MotivoConsulta,
                        x.MotivoEgreso,
                        x.HistoriaEnfermedad,
                        x.Nota,
                        x.TipoNota.Descripcion,
                        x.DeOrden,
                        x.Dieta,
                        x.ExamenFisico,
                        x.Observaciones,
                        x.Pronostico,
                        x.Fecha,
                        x.Peso,
                        x.UnidadPeso,
                        x.EscalaGlasgow,
                        x.EscalaDolor,
                        x.SaturacionOxigeno,
                        x.OtrosParametros,
                        x.CreatedAt,
                        x.UpdatedAt,
                        x.DeletedAt
                    });
                
                if (!string.IsNullOrEmpty(filter.AtencionId))
                {
                    objList = objList.Where(x => x.AtencionId.Equals(filter.AtencionId));
                }

                if (!string.IsNullOrEmpty(filter.MedicoId) || !string.IsNullOrWhiteSpace(filter.MedicoId))
                {
                    objList = objList.Where(x => x.MedicoId.Equals(filter.MedicoId));
                }

                if (filter.CreatedAt != null)
                {
                    objList = objList.Where(x => x.CreatedAt.Date.Equals(filter.CreatedAt.GetValueOrDefault().Date));
                }

                if (filter.UpdatedAt != null)
                {
                    objList = objList.Where(x => x.UpdatedAt.Date.Equals(filter.UpdatedAt.GetValueOrDefault().Date));
                }
                
                if (filter.DeletedAt != null)
                {
                    objList = objList.Where(x => x.DeletedAt.Date.Equals(filter.DeletedAt.GetValueOrDefault().Date));
                }

                return await objList.OrderByDescending(x => x.Fecha).Cast<object>().ToListAsync();
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
            return new List<object>();
        }

        public async Task<object> FindByIdAsync(string id)
        {
            object obj = null;
            try
            {
                obj = await _db.NotasMedica.FindAsync(id);
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

        public void Delete(NotaMedica model, bool disable = true)
        {
            try
            {
                if (disable)
                {
                    model.Deleted = true;
                    model.DeletedAt = DateTime.Now;
                    _db.NotasMedica.Update(model);
                }
                else
                {
                    _db.NotasMedica.Remove(model);
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