using _02_RestWithASPNET.Model.Context;
using _02_RestWithASPNET.Services;
using _02_RestWithASPNET.Services.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];
builder.Services.AddDbContext<MySQLContext>(options => options.UseMySql(
    connection,
    new MySqlServerVersion(new Version(8, 0, 29)))
);

// API de Versionamento
builder.Services.AddApiVersioning();


// Adicionando as services (Injeção de dependência)
builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();


var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
