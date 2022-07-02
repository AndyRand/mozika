using System;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mozika.EFCore;
using Mozika.Domain.DbInfo;
using Microsoft.Data.SqlClient;

namespace Mozika.API.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connection = String.Empty;
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                connection = configuration.GetConnectionString("MozikaDbWindows") ??
                             "Server=HERINIHAJA\\SQLEXPRESS,1433;Database=mozika;User=sa;Password=herinihaja;Trusted_Connection=True;Application Name=MozikaASPNETCoreAPINTier";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                connection = configuration.GetConnectionString("MozikaDbDocker") ??
                             "Server=localhost,1433;Database=Chinook;User=sa;Password=P@55w0rd;Trusted_Connection=False;";
            }

            services.AddDbContextPool<MozikaContext>(options => options.UseSqlServer(connection));

            services.AddSingleton(new SqlConnection(connection));
            
            services.AddSingleton(new DbInfo(connection));

            return services;
        }
    }
}