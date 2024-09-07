﻿using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Interfaces
{
	public interface ITypesRepository
	{
		Task<ProductType?> GetByIdAsync(int id);

		void Add(ProductType productType);
	}
}
