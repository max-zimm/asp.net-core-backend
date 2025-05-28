using Restaurants.Domain.Entities;
namespace Restaurants.Application.Restaurants;

internal class RestaurauntsService
{

    public Task<IEnumerable<Restaurant>> GetAllRestaurants()
    {
        // This is a placeholder for the actual implementation.
        // In a real application, you would retrieve the list of restaurants from a database or service.
        return Task.FromResult<IEnumerable<Restaurant>>(new List<Restaurant>());

    }
}

