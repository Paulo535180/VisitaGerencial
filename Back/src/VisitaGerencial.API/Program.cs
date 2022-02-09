using Microsoft.EntityFrameworkCore;
using VisitaGerencial.API.Data;
using VisitaGerencial.API.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(
    context => context.UseSqlServer(builder.Configuration.GetConnectionString("ConnDbSaude"))
);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injeção de Dependencia
builder.Services.AddScoped<Visita>();
builder.Services.AddScoped<Area>();
builder.Services.AddScoped<AreaParticipante>();
builder.Services.AddScoped<AcessoSistema>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
