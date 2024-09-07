using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Data
{
	public class AppCatalogContext : DbContext, IUnitOfWork
	{
        public AppCatalogContext(DbContextOptions options) : base(options)
        {
            
        }

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductBrand> ProductBrands { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }


	}
}
