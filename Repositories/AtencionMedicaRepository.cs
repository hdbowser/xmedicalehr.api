using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;
using xmedicalehr.api.Core;

namespace xmedicalehr.api.Repositories
{
    public class AtencionMedicaRepository : Repository
    {
        public AtencionMedicaRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(AtencionMedica model)
        {
            try
            {
                model.Id = Guid.NewGuid().ToString();
                model.CreatedAt = DateTime.Now;
                await _db.AtencionesMedicas.AddAsync(model);
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

        public void Update(AtencionMedica model)
        {
            try
            {
                model.UpdatedAt = DateTime.Now;
                _db.AtencionesMedicas.Update(model);
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
                objList = await _db.AtencionesMedicas.Cast<object>().ToListAsync();
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

        public async Task<object> FindByIdAsync(string id)
        {
            object obj = null;
            try
            {
                obj = await _db.AtencionesMedicas.FindAsync(id);
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

        public void Delete(AtencionMedica model, bool disable = true)
        {
            try
            {
                if (disable)
                {
                    model.Deleted = true;
                    model.DeletedAt = DateTime.Now;
                    _db.AtencionesMedicas.Update(model);
                }
                else
                {
                    _db.AtencionesMedicas.Remove(model);
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