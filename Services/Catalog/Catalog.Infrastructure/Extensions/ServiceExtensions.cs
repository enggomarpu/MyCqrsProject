using Catalog.Domain.Interfaces;
using Catalog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Catalog.Infrastructure.Extensions
{
	public static class ServiceExtensions
	{
		public static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
		{
			services.AddDbContext<AppCatalogContext>(opts => opts.UseSqlServer(config.GetConnectionString("sqlConnection")));
			services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<AppCatalogContext>());
			//services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IProductRepository, ProductRepository>();
			//services.AddScoped<IProductRespository, ProductRepository>();

		}
	}
}
