using developChallenge.Domain.Entities;
using developChallenge.Domain.Interfaces.Repository;
using developChallenge.Domain.Interfaces.Services;
using developChallenge.Infra.Context;
using developChallenge.Infra.Repository;
using developChallenge.Service;
using developChallenge.Web.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
var builder = WebApplication.CreateBuilder(args);

Serilog.Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
    
// Add services to the container.
Console.WriteLine("hello world");
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//SQL Server
builder.Services.AddDbContext<MyDatabaseContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Transient);

//builder.Services.AddDbContext<MyDatabaseContext>(options =>
//{
//    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
//}, ServiceLifetime.Transient);

// Register the implementation of IAirportServices
builder.Services.AddScoped<IAirportServices, AirportServices>();
builder.Services.AddScoped<ICityServices, CityServices>();
builder.Services.AddScoped<IAirportInfoRepository, AirportInfoRepository>();
builder.Services.AddScoped<IAirportRepository, AirportRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ILoggerRepository, LoggerRepository>();
// Add HttpClient
builder.Services.AddHttpClient();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLogging(loggingBuilder =>
{
    loggingBuilder.AddConsole(); // Enable console logging
    loggingBuilder.AddDebug();   // Enable debugging window logging
});
var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.Use(async (context, next) =>
{
    Serilog.Log.Information($"Received request: {context.Request.Method} {context.Request.Path}");
    await next();
});

app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Startup>>();
    logger.LogInformation($"Received request: {context.Request.Method} {context.Request.Path}");

    try
    {
        await next();
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "An unhandled exception occurred.");
        throw; // Rethrow the exception to let ASP.NET Core handle it
    }
});
app.Use(async (context, next) =>
{
    await next();
    var logger = context.RequestServices.GetRequiredService<ILogger<Startup>>();
    logger.LogInformation($"Response status code: {context.Response.StatusCode}");
    // You can log more response details as needed
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            }).ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddConsole(); // Add the console logger
            });

