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

        public AntecedentePacienteRepository AntecedentePacienteRepository
        {
            get
            {
                return new AntecedentePacienteRepository(_dbContext, _configuration, _result);
            }
        }

        public NacionalidadRepository NacionalidadRepository
        {
            get
            {
                return new NacionalidadRepository(_dbContext, _configuration, _result);
            }
        }

        public ProvinciaRepository ProvinciaRepository
        {
            get
            {
                return new ProvinciaRepository(_dbContext, _configuration, _result);
            }
        }

        public TipoAtencionRepository TipoAtencionRepository
        {
            get
            {
                return new TipoAtencionRepository(_dbContext, _configuration, _result);
            }
        }

        public DepartamentoRepository DepartamentoRepository
        {
            get
            {
                return new DepartamentoRepository(_dbContext, _configuration, _result);
            }
        }

        public EmpresaRepository EmpresaRepository
        {
            get
            {
                return new EmpresaRepository(_dbContext, _configuration, _result);
            }
        }

        public EnfermedadRepository EnfermedadRepository
        {
            get
            {
                return new EnfermedadRepository(_dbContext, _configuration, _result);
            }
        }

        public EstudioRepository EstudioRepository
        {
            get
            {
                return new EstudioRepository(_dbContext, _configuration, _result);
            }
        }

        public ExploracionItemRepository ExploracionItemRepository
        {
            get
            {
                return new ExploracionItemRepository(_dbContext, _configuration, _result);
            }
        }

        public ExploracionItemTemplaterepository ExploracionItemTemplaterepository
        {
            get
            {
                return new ExploracionItemTemplaterepository(_dbContext, _configuration, _result);
            }
        }

        public GrupoAntecedenteRepository GrupoAntecedenteRepository
        {
            get
            {
                return new GrupoAntecedenteRepository(_dbContext, _configuration, _result);
            }
        }

        public MedicacionRepository MedicacionRepository
        {
            get
            {
                return new MedicacionRepository(_dbContext, _configuration, _result);
            }
        }

        public MedicamentoRepository MedicamentoRepository
        {
            get
            {
                return new MedicamentoRepository(_dbContext, _configuration, _result);
            }
        }

        public NotaMedicaCustomFieldRepository NotaMedicaCustomFieldRepository
        {
            get
            {
                return new NotaMedicaCustomFieldRepository(_dbContext, _configuration, _result);
            }
        }

        public OrdenMedicaRepository OrdenMedicaRepository
        {
            get
            {
                return new OrdenMedicaRepository(_dbContext, _configuration, _result);
            }
        }

        public PacienteParentescoRepository PacienteParentescoRepository
        {
            get
            {
                return new PacienteParentescoRepository(_dbContext, _configuration, _result);
            }
        }

        public SignosVitalesRepository SignosVitalesRepository
        {
            get
            {
                return new SignosVitalesRepository(_dbContext, _configuration, _result);
            }
        }

        public SolicitudesInterconsultasRepository SolicitudesInterconsultasRepository
        {
            get
            {
                return new SolicitudesInterconsultasRepository(_dbContext, _configuration, _result);
            }
        }

        public SustanciaRepository SustanciaRepository
        {
            get
            {
                return new SustanciaRepository(_dbContext, _configuration, _result);
            }
        }

        public TipoAntecedenteRepository TipoAntecedenteRepository
        {
            get
            {
                return new TipoAntecedenteRepository(_dbContext, _configuration, _result);
            }
        }

        public TipoNotaMedicaRepository TipoNotaMedicaRepository
        {
            get
            {
                return new TipoNotaMedicaRepository(_dbContext, _configuration, _result);
            }
        }

        public TipoParentescoRepository TipoParentescoRepository
        {
            get
            {
                return new TipoParentescoRepository(_dbContext, _configuration, _result);
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