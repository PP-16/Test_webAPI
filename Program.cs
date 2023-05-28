global using System.ComponentModel.DataAnnotations;
global using SchoolSync.DAL.Repositories.Interfaces;
global using SchoolSync.DAL.Entities;
global using SchoolSync.DAL.Repositories.Response;
global using SchoolSync.DAL.EFCore;
global using Microsoft.EntityFrameworkCore;
global using SchoolSync.DAL.Helper;
using SchoolSync.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);    
builder.Services.ConfigureCors();
builder.Services.ConfigService();

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
