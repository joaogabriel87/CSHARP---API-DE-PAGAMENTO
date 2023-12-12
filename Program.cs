using ApiPagamento.Context;
using ApiPagamento.services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<PagamentoPix>();
builder.Services.AddTransient<PagamentoCartao>();
builder.Services.AddScoped<PagamentoContext, PagamentoContext>();
builder.Services.AddControllers();
builder.Services.AddDbContext<PagamentoContext>(opt =>
opt.UseInMemoryDatabase("PagamentoApi"));
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
