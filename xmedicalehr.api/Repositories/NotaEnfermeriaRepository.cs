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
    public class NotaEnfermeriaRepository : Repository
    {
        public NotaEnfermeriaRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(NotaEnfermeria model)
        {
            try
            {
                model.Id = Guid.NewGuid().ToString();
                model.CreatedAt = DateTime.Now;
                await _db.NotasEnfermeria.AddAsync(model);
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

        public void Update(NotaEnfermeria model)
        {
            try
            {
                model.UpdatedAt = DateTime.Now;
                _db.NotasEnfermeria.Update(model);
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

        public async Task<List<object>> FilterAsync(NotaEnfermeriaFilter filter)
        {
            try
            {
                var objList = await _db.NotasEnfermeria
                    .Include(x => x.AtencionMedica)
                    .Include(x => x.Enfermera)
                    .Where(x => !x.Deleted)
                    .Select(x => new {
                        x.Id,
                        x.AtencionId,
                        x.HabitusExterior,
                        x.Observaciones,
                        x.Enfermera.Name,
                        x.Fecha,
                        x.CreatedBy,
                        x.CreatedAt,
                        x.UpdatedAt,
                        x.DeletedAt,
                        x.Deleted
                    })
                    .ToListAsync();

                if (string.IsNullOrEmpty(filter.AtencionId) || string.IsNullOrWhiteSpace(filter.AtencionId))
                {
                    objList.Where(x => x.AtencionId.Equals(filter.AtencionId));
                }
                if (filter.CreatedAt != null)
                {
                    objList.Where(x => x.CreatedAt.Date.Equals(filter.CreatedAt.GetValueOrDefault().Date));
                }
                if (filter.UpdatedAt != null)
                {
                    objList.Where(x => x.UpdatedAt.Date.Equals(filter.UpdatedAt.GetValueOrDefault().Date));
                }
                if (filter.DeletedAt != null)
                {
                    objList.Where(x => x.DeletedAt.Date.Equals(filter.DeletedAt.GetValueOrDefault().Date));
                }

                return objList.Cast<object>().ToList();
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
                obj = await _db.NotasEnfermeria.FindAsync(id);
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

        public void Delete(NotaEnfermeria model, bool disable = true)
        {
            try
            {
                if (disable)
                {
                    model.Deleted = true;
                    model.DeletedAt = DateTime.Now;
                    _db.NotasEnfermeria.Update(model);
                }
                else
                {
                    _db.NotasEnfermeria.Remove(model);
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