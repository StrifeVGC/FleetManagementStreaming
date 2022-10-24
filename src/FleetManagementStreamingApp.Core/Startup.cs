using FleetManagementStreamingApp.Domain.Repos.Contract;
using FleetManagementStreamingApp.Domain.Repos.Implementation;
using FleetManagementStreamingApp.Infrastructure.Services.Contract;
using FleetManagementStreamingApp.Infrastructure.Services.Implementation;
using MongoDB.Driver;

namespace FleetManagementStreamingApp.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            ConfigureDbContext(services);
            ConfigureInfrastructureServices(services);
            ConfigureMapper(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void ConfigureDbContext(IServiceCollection services)
        {
            services.AddSingleton<IMongoClient, MongoClient>(sp => new MongoClient(Configuration.GetConnectionString("FleetManagementDb")));

            services.AddSingleton<IBrandRepo, BrandRepo>();
            services.AddSingleton<ICarRepo, CarRepo>();
        }

        private void ConfigureInfrastructureServices(IServiceCollection services)
        {
            services.AddSingleton<ICarService, CarService>();
            services.AddSingleton<IBrandService, BrandService>();
        }

        private void ConfigureMapper(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
