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
    public class TipoAntecedenteRepository : Repository
    {
        public TipoAntecedenteRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(TipoAntecedente model)
        {
            try
            {
                await _db.TiposAntecedentes.AddAsync(model);
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if(ex.InnerException != null)
                {
                    _log.Error(ex.InnerException.Message);
                }
                else
                {
                    _log.Error(ex.InnerException.Message);
                }
            }
        }

        public void Update(TipoAntecedente model)
        {
            try
            {
                _db.TiposAntecedentes.Update(model);
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if(ex.InnerException != null)
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
                objList = await _db.TiposAntecedentes.Cast<object>().ToListAsync();
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if(ex.InnerException != null)
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

        public async Task<object> FindByIdAsync(int id)
        {
            object obj = null;
            try
            {
                obj = await _db.TiposAntecedentes.FindAsync(id);
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if(ex.InnerException != null)
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

        public void Delete(TipoAntecedente model)
        {
            try
            {
                _db.TiposAntecedentes.Update(model);
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add("No fue posible realizar la operacion");
                if(ex.InnerException != null)
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