using Microsoft.Extensions.DependencyInjection;
using Restaurants.Application.Restaurants;
using Restaurants.Domain.Repository;

namespace Restaurants.Application.Extensions;
public static class ServiceCollectionExtensions
{
    public static void AddRepository(this IServiceCollection services)
    {

      
        services.AddScoped<IRestaurauntsService, RestaurauntsService>();

    }
}

