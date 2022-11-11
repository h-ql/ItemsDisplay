using ItemsDisplay.Data;
using ItemsDisplay.Services;
using Microsoft.EntityFrameworkCore;

public static class ServiceExtension
{
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