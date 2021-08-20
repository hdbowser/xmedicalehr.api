using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using xmedicalehr.api.Core;
using xmedicalehr.api.Repositories;

namespace xmedicalehr.api.Data
{
    public class UnitOfWork
    {
        private readonly Logger _logger;
        private readonly AppDbContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly RepositoryResult _result;

        public PacienteRepository PacienteRepository
        {
            get
            {
                return new PacienteRepository(_dbContext, _configuration, _result);
            }
        }

        public HabitacionRepository HabitacionRepository
        {
            get
            {
                return new HabitacionRepository(_dbContext, _configuration, _result);
            }
        }

        public CamaRepository CamaRepository
        {
            get
            {
                return new CamaRepository(_dbContext, _configuration, _result);
            }
        }

        public AtencionMedicaRepository AtencionMedicaRepository
        {
            get
            {
                return new AtencionMedicaRepository(_dbContext, _configuration, _result);
            }
        }

        public AlergiaRepository AlergiaRepository
        {
            get
            {
                return new AlergiaRepository(_dbContext, _configuration, _result);
            }
        }

        public AseguradoraRepository AseguradoraRepository
        {
            get
            {
                return new AseguradoraRepository(_dbContext, _configuration, _result);
            }
        }

        public NotaMedicaRepository NotaMedicaRepository
        {
            get
            {
                return new NotaMedicaRepository(_dbContext, _configuration, _result);
            }
        }

        public NotaEnfermeriaRepository NotaEnfermeriaRepository
        {
            get
            {
                return new NotaEnfermeriaRepository(_dbContext, _configuration, _result);
            }
        }

        public DiagnosticoRepository DiagnosticoRepository
        {
            get
            {
                return new DiagnosticoRepository(_dbContext, _configuration, _result);
            }
        }

        public UnitOfWork(AppDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _result =  new RepositoryResult();
            _logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        public async Task<RepositoryResult> SaveAsync()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                _result.Errors.Add($"No fue posible realizar la operacion.");
                if (ex.InnerException != null)
                {
                    _result.Errors.Add(ex.InnerException.Message);
                    _logger.Error(ex.InnerException.Message);
                }
                else
                {
                    _result.Errors.Add(ex.Message);
                    _logger.Error(ex.Message);
                }
            }
            return _result;
        }
    }
}