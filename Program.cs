using PortfolioApi.Infrastructure.Persistence;
using PortfolioApi.StartupExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// MediatR Injection
RepositoryInjection.Configure(builder.Services);

// EF Context Configuration
ContextConfiguration.Configure(builder.Services);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Rate Limit
RateLimitConfiguration.Configure(builder.Services, builder.Configuration);

var app = builder.Build();

// Seed db
LocalContext.Seed(app.Services);

app.UseSwagger();
app.UseSwaggerUI();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseRateLimiter();

app.Run();
