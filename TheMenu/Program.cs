using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TheMenu.Application.Recipe.Queries;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Data;
using TheMenu.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TheMenuDBContext>(options => options.UseSqlServer("Server=localhost;Database=TheMenu;User Id=sa;Password=P@ssw0rd;"));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddMediatR(typeof(GetRecipeByIdQuery).GetTypeInfo().Assembly);

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
