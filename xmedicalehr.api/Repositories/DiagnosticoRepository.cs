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
    public class DiagnosticoRepository : Repository
    {
        public DiagnosticoRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(Diagnostico model)
        {
            try
            {
                var numItem = _db.Diagnosticos.Where(x => x.NotaMedicaId.Equals(model.NotaMedicaId)).Select(x => x.NumItem).Max();
                model.NumItem = (numItem > 0) ? numItem++ : 1;
                model.CreatedAt = DateTime.Now;

                await _db.Diagnosticos.AddAsync(model);
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

        public void Update(Diagnostico model)
        {
            try
            {
                model.UpdatedAt = DateTime.Now;
                _db.Diagnosticos.Update(model);
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

        public async Task<List<object>> FilterAsync(DiagnosticoFilter filter)
        {
            try
            {
                var objList = await _db.Diagnosticos
                    .Include(x => x.NotaMedica)
                    .Include(x => x.Enfermedad)
                    .Where(x => !x.Deleted)
                    .Select(x => new {
                        x.NotaMedicaId,
                        x.NumItem,
                        x.Enfermedad.Descripcion,
                        x.Comentario,
                        x.Deleted,
                        x.CreatedAt,
                        x.UpdatedAt,
                        x.DeletedAt
                    })
                    .ToListAsync();
                
                if (string.IsNullOrEmpty(filter.NotaMedicaId) || string.IsNullOrWhiteSpace(filter.NotaMedicaId))
                {
                    objList.Where(x => x.NotaMedicaId.Equals(filter.NotaMedicaId));
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

        public async Task<object> FindByIdAsync(string notaMedicaId, int numItem)
        {
            object obj = null;
            try
            {
                obj = await _db.Diagnosticos.FindAsync(notaMedicaId, numItem);
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

        public void Delete(Diagnostico model, bool disable = true)
        {
            try
            {
                if (disable)
                {
                    model.Deleted = true;
                    model.DeletedAt = DateTime.Now;
                    _db.Diagnosticos.Update(model);
                }
                else
                {
                    _db.Diagnosticos.Remove(model);
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