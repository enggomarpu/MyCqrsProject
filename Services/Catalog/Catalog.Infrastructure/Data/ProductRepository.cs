using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Data
{
	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
		private readonly AppCatalogContext _context;

		public ProductRepository(AppCatalogContext context) : base(context)
        {
			_context = context;
		}

		public async Task<IEnumerable<Product>> ListAllAsyncWithInclude()
		{
			return await _context.Products.Include(c => c.ProductBrand).Include(c => c.ProductType).ToListAsync();
		}
	}
}
