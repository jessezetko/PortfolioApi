using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

namespace PortfolioApi.StartupExtensions
{
    internal static class RateLimitConfiguration
    {
        internal static void Configure(this IServiceCollection services, IConfiguration configuration)
        {
            var myOptions = new RateLimitOptions();
            configuration.GetSection(RateLimitOptions.MyRateLimit).Bind(myOptions);

            services.AddRateLimiter(_ => _
            .AddFixedWindowLimiter(policyName: "fixed", options =>
            {
                options.PermitLimit = myOptions.PermitLimit;
                options.Window = TimeSpan.FromSeconds(myOptions.Window);
                options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                options.QueueLimit = myOptions.QueueLimit;
            }));
        }

        internal class RateLimitOptions()
        {
            public const string MyRateLimit = "MyRateLimit";

            public int PermitLimit { get; set; } = 8;

            public int Window { get; set; } = 10;

            public int ReplenishmentPeriod { get; set; } = 2;

            public int QueueLimit { get; set; } = 2;

            public int SegmentsPerWindow { get; set; } = 8;

            public int TokenLimit { get; set; } = 10;

            public int TokenLimit2 { get; set; } = 20;

            public int TokensPerPeriod { get; set; } = 4;

            public bool AutoReplenishment { get; set; } = false;
        }
    }
}
