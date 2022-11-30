using ItemsDisplay.Data;
using ItemsDisplay.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

public static class ServiceExtension
{
    public static void ConfigureSerilog(this WebApplicationBuilder builder)
    {
        builder.Host.UseSerilog((context, services, configuration) => configuration
                .ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext()
                .WriteTo.Console(theme: AnsiConsoleTheme.Code));
    }

    public static void ConfigureSQLite(this IServiceCollection svcs, IConfiguration cfg)
    {
        svcs.AddDbContext<CharacterContext>(
            otps => otps.UseSqlite(cfg.GetConnectionString("SqliteConn") 
                    ??  
                throw new InvalidOperationException("Connection string 'SqliteConn' not found!")                    
        ));
    }

    public static void ConfigureDI(this IServiceCollection svcs)
    {
        svcs.AddTransient<ICharacterService, CharacterService>();
    }

}