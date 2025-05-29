using Microsoft.AspNetCore.Mvc;
using Restaurants.Domain.Entities;
using Restaurants.Application.Restaurants;

namespace Restaurants.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantsController(IRestaurauntsService restaurauntsService) : ControllerBase
{



    [HttpGet]
    [Route("GetAllRestaurants")]
    public async Task<IActionResult> GetAllRestaurants()
    {
        try
        {
            var res = await restaurauntsService.GetAllRestaurants();
            return Ok(res);
        }
        catch(Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }

    
    }



}
