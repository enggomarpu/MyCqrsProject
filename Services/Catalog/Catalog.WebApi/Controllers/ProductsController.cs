using Catalog.Application.Products.Queries;
using Catalog.Application.Responses;
using Catalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Catalog.WebApi.Controllers
{
	public class ProductsController : BaseController
	{
		private readonly IMediator _mediatR;

		public ProductsController(IMediator mediatR)
        {
			_mediatR = mediatR;
		}

        [HttpGet]
		public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts()
		{
			var query = new GetProductsQuery();
			var result = await _mediatR.Send(query);
			return Ok(result);
		}
	}
}
