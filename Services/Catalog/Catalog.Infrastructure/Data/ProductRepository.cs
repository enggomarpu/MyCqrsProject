using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;


namespace Catalog.Infrastructure.Data
{
	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
        public ProductRepository(AppCatalogContext context) : base(context)
        {
            
        }
    }
}
