using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using EFPostgres;

var configBuilder = new ConfigurationBuilder();
configBuilder.AddEnvironmentVariables();
var config = configBuilder.Build();

var host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args);
host.ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.UseStartup<Startup>();
});

Console.WriteLine();

MoneyDbContext db = new MoneyDbContext(config);
var types = db.MetaAccountTypes;
foreach (var type in types)
{
    Console.WriteLine(type.DisplayName);
} 

Console.WriteLine("Done");
