using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFPostgres
{
    public partial class Startup
    {
        private readonly IConfiguration m_Config;
        public Startup(IConfiguration configuration)
        {
            m_Config = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var cn = m_Config.GetConnectionString("MoneyDb");
            //Enable CoreWCF Services, with metadata (WSDL) support
            services
                .AddEntityFrameworkNpgsql().AddDbContext<MoneyDbContext>(opt =>
                    opt.UseNpgsql(cn));
        }
    }
}
