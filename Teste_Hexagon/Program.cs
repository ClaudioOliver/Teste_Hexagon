using Microsoft.EntityFrameworkCore;
using Teste_Hexagon.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<Teste_HexagonContext>(options => options.UserInMemoryDatabase("PessoaDb"));
builder.Services.AddDbContext<Teste_HexagonContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrão")));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
