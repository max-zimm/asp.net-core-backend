using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurants.Domain.Entities;

namespace Restaurants.Domain.Repository;

public interface IRestaurantsRepository
{

    Task<IEnumerable<Restaurant>> GetAllAsync();
}
