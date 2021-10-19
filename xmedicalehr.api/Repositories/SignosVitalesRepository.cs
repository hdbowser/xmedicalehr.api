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
    public class SignosVitalesRepository : Repository
    {
        public SignosVitalesRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(SignosVitales model)
        {
            try
            {
                int num = 0;
                var numItems = await _db.Diagnosticos.Where(x => x.NotaMedicaId.Equals(model.NotaMedicaId)).Select(x => x.NumItem).ToListAsync();
                if(numItems.Count > 0)
                {
                    num = numItems.Max();
                }
                model.NumItem = (num > 0) ? num++ : 1;
                model.CreatedAt = DateTime.Now;
                await _db.SignosVitales.AddAsync(model);
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

        public void Update(SignosVitales model)
        {
            try
            {
                model.UpdatedAt = DateTime.Now;
                _db.SignosVitales.Update(model);
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

        public async Task<List<object>> FilterAsync(SignosVitalesFilter filter)
        {
            try
            {
                var objList = _db.SignosVitales
                    .Where(x => 
                        x.AtencionId.Equals(filter.AtencionId));

                if (!string.IsNullOrEmpty(filter.NotaMedicaId))
                {
                    objList = objList.Where(x => x.NotaMedicaId.Equals(filter.NotaMedicaId));
                }
                if (!string.IsNullOrEmpty(filter.NotaEnfermeriaId))
                {
                    objList = objList.Where(x => x.NotaEnfermeriaId.Equals(filter.NotaEnfermeriaId));
                }
                if (filter.NumItem > 0)
                {
                    objList = objList.Where(x => x.NumItem.Equals(filter.NumItem));
                }

                return await objList.Cast<object>().ToListAsync();
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

        public async Task<object> FindByIdAsync(string atencionId, string notaMedica, int NumItem)
        {
            object obj = null;
            try
            {
                obj = await _db.SignosVitales
                    .Where(x => x.AtencionId.Equals(atencionId) && x.NotaMedica.Equals(notaMedica) && x.NumItem.Equals(NumItem))
                    .FirstOrDefaultAsync();
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

        public void Delete(SignosVitales model, bool disable = true)
        {
            try
            {
                if (disable)
                {
                    model.Deleted = true;
                    model.DeletedAt = DateTime.Now;
                    _db.SignosVitales.Update(model);
                }
                else
                {
                    _db.SignosVitales.Remove(model);
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