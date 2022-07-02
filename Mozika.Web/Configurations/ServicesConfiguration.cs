using Mozika.AdoNet.Repositories;
//using Mozika.EFCore.Repositories;
using Mozika.Domain.Repositories;
using Mozika.Domain.Supervisor;
using Microsoft.Extensions.DependencyInjection;

namespace Mozika.Web.Configurations
{
    public static class ServicesConfiguration
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAlbumRepository, AlbumRepository>()
                .AddScoped<IArtistRepository, ArtistRepository>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
                .AddScoped<IGenreRepository, GenreRepository>()
                .AddScoped<IInvoiceRepository, InvoiceRepository>()
                .AddScoped<IInvoiceLineRepository, InvoiceLineRepository>()
                .AddScoped<IMediaTypeRepository, MediaTypeRepository>()
                .AddScoped<IPlaylistRepository, PlaylistRepository>()
                .AddScoped<ITrackRepository, TrackRepository>();
        }

        public static void ConfigureSupervisor(this IServiceCollection services)
        {
            services.AddScoped<IMozikaSupervisor, MozikaSupervisor>();
        }
    }
}