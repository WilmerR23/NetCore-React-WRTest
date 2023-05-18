using DGII.API.Extensions;
using DGII.API.Mappers;
using DGII.BLL.Contracts;
using DGII.BLL.Services;
using DGII.DAL.Data;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("dgii");
var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Value;
var corsPolicyName = builder.Configuration.GetSection("CorsPolicyName").Value;
LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

builder.Services.AddDbContext<DGIIContext>(options =>
    {
        options.UseSqlServer(connectionString);
        options.EnableSensitiveDataLogging();
    }
);

builder.Services.AddSingleton<ILoggerService, LoggerService>();
builder.Services.AddScoped<IDbContext, DGIIContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(DGIIProfile));

builder.Services.AddCors(options =>
{
    options.AddPolicy(corsPolicyName,
                          policy =>
                          {
                              policy.WithOrigins(allowedOrigins)
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuracion Nlog
builder.Logging.ClearProviders();
builder.Host.UseNLog();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureCustomExceptionMiddleware();

app.UseHttpsRedirection();

app.UseCors(corsPolicyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
