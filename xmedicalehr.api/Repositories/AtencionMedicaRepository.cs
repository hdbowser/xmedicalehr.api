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

        public async Task<List<object>> FilterAsync(AtencionFilter filter = null)
        {
            try
            {
                var objList = _db.AtencionesMedicas
                    .Include(x => x.Paciente)
                    .Include(x => x.Medico)
                    .Include(x => x.Creator)
                    .Include(x => x.Aseguradora)
                    .Include(x => x.Cama)
                    .Where(x =>!x.Deleted)
                    .Select(x => new
                    {
                        x.Id,
                        x.PacienteId,
                        NombrePaciente = $"{x.Paciente.Nombres} {x.Paciente.PrimerApellido} {x.Paciente.SegundoApellido}",
                        x.EdadPaciente,
                        Aseguradora = x.Aseguradora.Nombre,
                        Cama = x.Cama.Descripcion,
                        x.Origen,
                        x.NombreFinanciador,
                        x.TipoFinanciamiento,
                        x.FirmaPaciente,
                        NombreMedico = x.Medico.Name,
                        x.FechaIngreso,
                        x.CreatedAt,
                        CreatedBy = x.Creator.Name,
                        x.UpdatedAt,
                        x.DeletedAt
                    });
                

                if (!string.IsNullOrEmpty(filter.PacienteId))
                {
                    objList = objList.Where(x => x.PacienteId.Equals(filter.PacienteId));
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

                return await objList.OrderByDescending(x => x.FechaIngreso).Cast<object>().ToListAsync();
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