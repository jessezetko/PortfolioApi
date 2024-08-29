using BusinessLogic.Contexts;
using BusinessLogic.Repositories.Interfaces;
using BusinessLogic.Repositories;

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
