


using Restaurants.Infastructure.Persistence;
using Restaurants.Domain.Entities;

namespace Restaurants.Infastructure.Seeders;

internal class RestaurantSeeder(RestaurantsDbContext dbContext) : IRestaurantSeeder
{

    public async Task Seed()
    {
        if(await dbContext.Database.CanConnectAsync())
        {
            if(!dbContext.Restaurants.Any())
            {
                var res = GetRestaurants();
                dbContext.Restaurants.AddRange(res);
                dbContext.Restaurants.AddRange(res);
            }
        }


        await dbContext.SaveChangesAsync();
            
    }

    private IEnumerable<Restaurant> GetRestaurants()
    {
        return new List<Restaurant>
        {
            new Restaurant
            {
                Name = "Pizza Palace",
                Description = "Authentic Italian pizzas and pasta.",
                Category = "Italian",
                HasDelivery = true,
                ContactEmail = "info@pizzapalace.com",
                ContactNumber = "555-123-4567",
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    PostalCode = "12345"
                },
                Dishes = new List<Dish>
                {
                    new Dish
                    {
                        Name = "Margherita Pizza",
                        Description = "Classic pizza with tomato, mozzarella, and basil.",
                        Price = 12.50m,
                        KiloCalories = 800
                    },
                    new Dish
                    {
                        Name = "Spaghetti Carbonara",
                        Description = "Creamy pasta with pancetta and egg yolk.",
                        Price = 15.00m,
                        KiloCalories = 950
                    }
                }
            },
            new Restaurant
            {
                Name = "Sushi Haven",
                Description = "Fresh and delicious sushi and sashimi.",
                Category = "Japanese",
                HasDelivery = true,
                ContactEmail = "contact@sushihaven.com",
                ContactNumber = "555-987-6543",
                Address = new Address
                {
                    Street = "456 Oak Ave",
                    City = "Anytown",
                    PostalCode = "12345"
                },
                Dishes = new List<Dish>
                {
                    new Dish
                    {
                        Name = "California Roll",
                        Description = "Crab, avocado, and cucumber roll.",
                        Price = 8.75m,
                        KiloCalories = 350
                    },
                    new Dish
                    {
                        Name = "Sashimi Platter",
                        Description = "Assortment of fresh sliced fish.",
                        Price = 25.00m,
                        KiloCalories = 600
                    }
                }
            },
            new Restaurant
            {
                Name = "Burger Joint",
                Description = "Gourmet burgers and fries.",
                Category = "American",
                HasDelivery = false,
                ContactEmail = null, // Example of a null contact email
                ContactNumber = "555-111-2222",
                Address = new Address
                {
                    Street = "789 Pine Ln",
                    City = "Anytown",
                    PostalCode = "12345"
                },
                Dishes = new List<Dish>
                {
                    new Dish
                    {
                        Name = "Classic Cheeseburger",
                        Description = "Beef patty with cheese, lettuce, and tomato.",
                        Price = 10.00m,
                        KiloCalories = 700
                    },
                    new Dish
                    {
                        Name = "Sweet Potato Fries",
                        Description = "Crispy sweet potato fries.",
                        Price = 4.50m,
                        KiloCalories = 400
                    }
                }
            }
        };
    }

}
