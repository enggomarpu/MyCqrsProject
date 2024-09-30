using AutoMapper;
using Catalog.Application.Products.Queries;
using Catalog.Application.Responses;
using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;
using MediatR;

namespace Catalog.Application.Handlers
{
	public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductResponse>>
	{
		private readonly IProductRepository _prodRepo;
		private readonly IMapper _mapper;

		public GetProductsHandler(IProductRepository prodRepo, IMapper mapper)
        {
			_prodRepo = prodRepo;
			_mapper = mapper;
		}
        public async Task<IEnumerable<ProductResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
		{
			var products = await _prodRepo.ListAllAsyncWithInclude();
			var mappedProducts = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResponse>>(products);
			return mappedProducts;
		}
	}
}
