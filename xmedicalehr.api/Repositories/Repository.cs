using Serilog;
using Serilog.Core;
using Microsoft.Extensions.Configuration;
using xmedicalehr.api.Data;
using xmedicalehr.api.Core;

namespace xmedicalehr.api.Repositories
{
    public class Repository
    {
        protected readonly AppDbContext _db;
        protected readonly IConfiguration _conf;
        protected readonly RepositoryResult _result;
        protected readonly Logger _log;

        public Repository(AppDbContext dbContext, IConfiguration configuration, RepositoryResult result)
        {
            _db = dbContext;
            _conf = configuration;
            _result = result;
            _log = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }
    }
}