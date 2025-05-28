using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Restaurants.Infastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Restaurants.Infastructure.Seeders;

namespace Restaurants.Infastructure.Extensions;
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("RestaurantsDb");
        services.AddDbContext<RestaurantsDbContext>(options=> options.UseSqlServer(connectionString));

        services.AddScoped<IRestaurantSeeder, RestaurantSeeder>();

    }
    }

