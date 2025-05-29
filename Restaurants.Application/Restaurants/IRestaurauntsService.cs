using Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurants;

public interface IRestaurauntsService
{
    Task<IEnumerable<Restaurant>> GetAllRestaurants();
}