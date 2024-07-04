using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFPostgres;

public class MoneyDbContext : DbContext
{
    private IConfiguration m_Config;
    public DbSet<MetaAccountType> MetaAccountTypes { get; set; }

    public MoneyDbContext(IConfiguration configuration)
    {
        m_Config = configuration;      
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {           
        var cn = m_Config.GetConnectionString("MoneyDb");
        optionsBuilder.UseNpgsql(cn);
    }
}