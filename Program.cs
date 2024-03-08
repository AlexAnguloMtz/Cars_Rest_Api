using Cars.src.Persistence;
using Cars.src.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string WEB_APP_NAME = "Front-End Web App";

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: WEB_APP_NAME, policy => {
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader() 
            .AllowAnyMethod(); 
    });
});

// Controllers
builder.Services.AddControllers();

// Database Contexts
builder.Services.AddDbContext<CarContext>(options => options.UseSqlServer("Server=localhost,1433;Database=CarsDatabase;User Id=SA;Password=Tacodemanzana1!;TrustServerCertificate=true"));

// Repositories
builder.Services.AddScoped<ICarRepository, EFCarRepository>();

// Services
builder.Services.AddScoped<ICarService, CarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(WEB_APP_NAME);

app.UseAuthorization();

app.MapControllers();

app.Run();

