using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repository;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurants.Infastructure.Persistence;

namespace Restaurants.Infastructure.Repository;

internal class RestaurantsRepository(RestaurantsDbContext dbContext) : IRestaurantsRepository
{
    public async Task<IEnumerable<Restaurant>> GetAllAsync()
    {
        var res = await dbContext.Restaurants.ToListAsync();
        return res;
    }
}
