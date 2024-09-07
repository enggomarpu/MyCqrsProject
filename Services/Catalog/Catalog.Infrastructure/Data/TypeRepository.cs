using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;

namespace Catalog.Infrastructure.Data
{
	public class TypeRepository: GenericRepository<ProductType>, ITypesRepository
	{
        public TypeRepository(AppCatalogContext context) : base(context)
        {
            
        }
    }
}
