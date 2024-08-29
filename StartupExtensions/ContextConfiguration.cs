using BusinessLogic.Contexts;
using Microsoft.EntityFrameworkCore;

namespace PortfolioApi.StartupExtensions
{
    internal static class ContextConfiguration
    {
        internal static void Configure(this IServiceCollection services)
        {
            // Create local DB & Seed Data
            services.AddDbContext<LocalContext>(options =>
            {
                options.UseInMemoryDatabase("TestDB");
            });
        }
    }
}
