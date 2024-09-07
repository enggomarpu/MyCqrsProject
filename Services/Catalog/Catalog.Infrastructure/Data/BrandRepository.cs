

using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;

namespace Catalog.Infrastructure.Data
{
	public class BrandRepository : GenericRepository<ProductBrand>, IBrandRepository
	{
        public BrandRepository(AppCatalogContext context): base(context)
        {
            
        }
    }
}
