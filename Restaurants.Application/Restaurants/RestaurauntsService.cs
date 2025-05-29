using Microsoft.Extensions.Logging;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repository;
namespace Restaurants.Application.Restaurants;

internal class RestaurauntsService(IRestaurantsRepository restaurantsRepository, ILogger<RestaurauntsService> logger) : IRestaurauntsService
{

    public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        logger.LogInformation("Fetching all restaurants from the repository.");

        return await restaurantsRepository.GetAllAsync();

    }
}

