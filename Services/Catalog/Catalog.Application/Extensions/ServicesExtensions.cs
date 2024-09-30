

using Catalog.Domain.Interfaces;
using Catalog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Catalog.Application.Extensions
{
	public static class ServicesExtensions
    {
		public static void AddApplictionServices(this IServiceCollection services)
		{
			services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServicesExtensions).Assembly));
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
		}

	}
}