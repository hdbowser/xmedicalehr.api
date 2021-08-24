using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Data;
using xmedicalehr.api.Models;
using xmedicalehr.api.Core;
using xmedicalehr.api.Core.FilterClass;

namespace xmedicalehr.api.Repositories
{
    public class AntecedentePacienteRepository : Repository
    {
        public AntecedentePacienteRepository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result) : base(dbContext, configuration, result)
        {
        }

        public async Task AddAsync(AntecedentePaciente model)
        {
            try
            {
                model.CreatedAt = DateTime.Now;
                await _db.AntecedetesPacientes.AddAsync(model);
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

        public void Update(AntecedentePaciente model)
        {
            try
            {
                model.UpdatedAt = DateTime.Now;
                _db.AntecedetesPacientes.Update(model);
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

        public async Task<List<object>> FilterAsync(AntecedenteFilter filter)
        {
            try
            {
                var objList = await _db.AntecedetesPacientes.ToListAsync();

                if (string.IsNullOrEmpty(filter.PacienteId))
                {
                    objList.Where(x => x.PacienteId.Equals(filter.PacienteId));
                }

                return objList.Cast<object>().ToList();
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
            return new List<object>();
        }

        public async Task<object> FindByIdAsync(string pacienteId, string tipoAntecedenteId)
        {
            object obj = null;
            try
            {
                obj = await _db.AntecedetesPacientes.FindAsync(pacienteId, tipoAntecedenteId);
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

        public void Delete(AntecedentePaciente model, bool disable = true)
        {
            try
            {
                if (disable)
                {    
                    model.Deleted = true;
                    model.DeletedAt = DateTime.Now;
                    _db.AntecedetesPacientes.Update(model);
                }
                else
                {
                    _db.AntecedetesPacientes.Remove(model);
                }
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