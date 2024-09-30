using Catalog.Application.Responses;
using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
namespace Catalog.Application.Mappers
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Product, ProductResponse>()
				.ForMember(d => d.ProductType, s => s.MapFrom(sf => sf.ProductType.Name))
				.ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name));

		}
	}
}
