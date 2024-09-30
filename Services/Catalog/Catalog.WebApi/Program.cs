using Catalog.Application.Extensions;
using Catalog.Infrastructure.Data;
using Catalog.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplictionServices();
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

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;
	var loggerFactory = services.GetRequiredService<ILoggerFactory>();
	try
	{
		var context = services.GetRequiredService<AppCatalogContext>();
		await context.Database.MigrateAsync();
		await StoreContextSeed.SeedAsync(context, loggerFactory);

	}
	catch (Exception ex)
	{
		var logger = loggerFactory.CreateLogger<Program>();
		logger.LogError(ex, "An error occured during migration");
	}
}

app.Run();
