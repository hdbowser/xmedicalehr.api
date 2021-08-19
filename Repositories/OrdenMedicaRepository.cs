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
                var numItem = _db.OrdenesMedica.Where(x => x.NotaMedicaId.Equals(model.NotaMedicaId)).Select(x => x.NumItem).Max();
                model.NumItem = (numItem > 0) ? numItem++ : 1;
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

        public async Task<List<object>> FilterAsync(string filter = "")
        {
            var objList = new List<object>();
            try
            {
                objList = await _db.OrdenesMedica.Cast<object>().ToListAsync();
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

        public async Task<object> FindByIdAsync(string notaMedicaId, int numItem)
        {
            object obj = null;
            try
            {
                obj = await _db.OrdenesMedica.FindAsync(notaMedicaId, numItem);
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