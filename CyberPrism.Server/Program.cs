using CyberPrism.Server.Services;
using CyberPrism.Server.Data;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Entry point for the CyberPrism Server application.
/// </summary>

var builder = WebApplication.CreateBuilder(args);
if (builder.Environment.IsDevelopment())
{
    builder.WebHost.UseUrls("http://localhost:5133");
}

// 1. Database: Configure PostgreSQL
builder.Services.AddDbContext<IndustrialDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Register API Controllers
builder.Services.AddControllers();

// 3. Register Business Logic services
builder.Services.AddScoped<DatabaseService>();

// AddHostedService: Starts background worker to generate recurring simulated data
builder.Services.AddHostedService<DataGeneratorService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Check and initialize the database with seed data before starting
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var configuration = services.GetRequiredService<IConfiguration>();
    DatabaseSeeder.Initialize(services, configuration);
}

// Run the application and start listening for requests
app.Run();

// Summary: Program.cs coordinates DB, API, and background workers, acting as the system's control center.
