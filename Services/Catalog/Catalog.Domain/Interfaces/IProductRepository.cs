using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Interfaces
{
	public interface IProductRepository
	{
		Task<Product?> GetByIdAsync(int id);

		Task<IEnumerable<Product>> ListAllAsync();
		Task<IEnumerable<Product>> ListAllAsyncWithInclude();
		void Add(Product product);
	}
}
