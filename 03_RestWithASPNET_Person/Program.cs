using _02_RestWithASPNET.Services;
using _02_RestWithASPNET.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Adicionando as services (Injeção de dependência)
builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();


var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
