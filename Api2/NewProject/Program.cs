using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using NewProject.Models;
using Microsoft.AspNetCore.Authentication;
using NewProject.Halndler; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("ProjectConnection"); 
builder.Services.AddDbContext<EmpContext>(options => options.UseSqlServer(connectionString));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions ,BasicAuthenticationHandler>("BasicAuthentication",null);  

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
 
app.UseAuthorization();

app.MapControllers();

app.Run();
