using Microsoft.EntityFrameworkCore;
using PortfolioApi.Infrastructure.Persistence;

namespace PortfolioApi.StartupExtensions
{
    internal static class ContextConfiguration
    {
        internal static void Configure(this IServiceCollection services)
        {
            services.AddDbContext<LocalContext>(options =>
            {
                options.UseInMemoryDatabase("TestDB");
            });
        }
    }
}
