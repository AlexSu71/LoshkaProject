using LoshkaLibrary.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.EntityFrameworkCore;
using LoshkaWebApi.DTOModels.Mappings;
using System.Globalization;
using LoshkaLibrary.Interfaces;
using LoshkaLibrary.UnitOfWork;
using LoshkaLibrary.Repositories;

var builder = WebApplication.CreateBuilder(args);

CultureInfo defaultCulture = new("en-US");
CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAppDbContext, AppDbContext>(provider => provider.GetService<AppDbContext>());
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUnitRepository, UnitRepository>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();

builder.Services.AddTransient<DatabaseConfiguration>();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
