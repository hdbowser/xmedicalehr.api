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
    public class SolicitudesInterconsultasRepository : Repository
    {
        public SolicitudesInterconsultasRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(SolicitudInterconsulta model)
        {
            try
            {
                var numItem = _db.SolicitudesInterconsultas.Where(x => x.AtencionId.Equals(model.AtencionId)).Select(x => x.NumItem).Max();
                model.NumItem = (numItem > 0) ? numItem++ : 1;
                model.CreatedAt = DateTime.Now;

                await _db.SolicitudesInterconsultas.AddAsync(model);
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

        public void Update(SolicitudInterconsulta model)
        {
            try
            {
                _db.SolicitudesInterconsultas.Update(model);
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
                objList = await _db.SolicitudesInterconsultas.Cast<object>().ToListAsync();
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

        public async Task<object> FindByIdAsync(string atencionId, int NumItem)
        {
            object obj = null;
            try
            {
                obj = await _db.SolicitudesInterconsultas.FindAsync(atencionId, NumItem);
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

        public void Delete(SolicitudInterconsulta model)
        {
            try
            {
                model.Deleted = true;
                _db.SolicitudesInterconsultas.Update(model);
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