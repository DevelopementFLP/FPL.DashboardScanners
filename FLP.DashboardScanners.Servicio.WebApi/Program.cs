using FLP.DashboardScanners.Aplicacion.Interface;
using FLP.DashboardScanners.Aplicacion.Main;
using FLP.DashboardScanners.Dominio.Core;
using FLP.DashboardScanners.Dominio.Interface;
using FLP.DashboardScanners.Infraestructura.Interface;
using FLP.DashboardScanners.Infraestructura.Repository;
using FLP.DashboardScanners.Interface;
using FPL.DashboardScanners.Infraestructura.Data;
using FPL.DashboardScanners.Transversal.Common;
using FPL.DashboardScanners.Transversal.Mapper;

var builder = WebApplication.CreateBuilder(args);
var corsPolicy = "dashboardPolicy";

// Add services to the container.
builder.Services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));
builder.Services.AddSingleton<IConnectionFactory, ConnectionFactory>();
builder.Services.AddScoped<ILecturaResponseAplicacion, LecturaResponseAplicacion>();
builder.Services.AddScoped<IRatioDeErrorResponseAplicacion, RatioDeErrorResponseAplicacion>();
builder.Services.AddScoped<IDispositivoAplicacion, DispositivoAplicacion>();
builder.Services.AddScoped<IRastreoCajaResponseAplicacion, RastreoCajaResponseAplicacion>();
builder.Services.AddScoped<ILecturaResponseDomain, LecturaResponseDomain>();
builder.Services.AddScoped<IRatioDeErrorDomain, RatioDeErrorDomain>();
builder.Services.AddScoped<IDispositivoDomain, DispositivoDomain>();
builder.Services.AddScoped<IRastreoCajaDomain, RastreoCajaDomain>();
builder.Services.AddScoped<ILecturaRepository, LecturaRepository>();

builder.Services.AddCors(options => options.AddPolicy(corsPolicy, bldr => bldr.AllowAnyOrigin()
                                                                               .AllowAnyHeader()
                                                                               .AllowAnyMethod()));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.UseCors(corsPolicy);

app.Run();
