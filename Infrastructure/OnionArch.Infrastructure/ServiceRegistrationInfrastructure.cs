using Microsoft.Extensions.DependencyInjection;
using OnionArch.Application.Interfaces;
using OnionArch.Infrastructure.Concretes;


namespace OnionArch.Infrastructure
{
    public static class ServiceRegistrationInfrastructure
    {
        public static void RegisterInfra(this IServiceCollection services)
        {
            // Correctly register ProductService as the implementation of IProductService
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
