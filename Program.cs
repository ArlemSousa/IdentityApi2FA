using IdentityApi.Data;
using IdentityApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApiIdentity;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<User>().AddEntityFrameworkStores<AppDbContext>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
   
}

app.MapIdentityApi<User>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.Run();
