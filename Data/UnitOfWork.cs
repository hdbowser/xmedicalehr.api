using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using xmedicalehr.api.Data;
using xmedicalehr.api.Core;

namespace xmedicalehr.api.Data
{
    public class UnitOfWork
    {
        private readonly Logger _logger;
        private readonly AppDbContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly RepositoryResult _result;

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
                _result.Errors.Add("No fue posible realizar la operacion");
                if (ex.InnerException != null)
                {
                    _logger.Error(ex.InnerException.Message);
                }
                else
                {
                    _logger.Error(ex.Message);
                }
            }
            return _result;
        }
    }
}