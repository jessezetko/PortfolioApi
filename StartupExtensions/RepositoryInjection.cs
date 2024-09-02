using PortfolioApi.Infrastructure.Persistence;
using PortfolioApi.Infrastructure.Persistence.Repositories;
using PortfolioApi.Infrastructure.Persistence.Repositories.Interfaces;

namespace PortfolioApi.StartupExtensions
{
    internal static class RepositoryInjection
    {
        internal static void Configure(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(LocalContext).Assembly));
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
