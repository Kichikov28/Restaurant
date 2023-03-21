namespace Restaurant.WebApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Restaurant.Services;
    using Restaurant.ViewModel.Restaurants;
    using System.Collections.Generic;
    public class RestaurantsController : Controller
    {
        private readonly RestaurantsService restaurantsService;

        public RestaurantsController()
        {
            this.restaurantsService = new RestaurantsService();
        }
        public IActionResult Index(int page = 1)
        {
            RestaurantsIndexViewModel models = new RestaurantsIndexViewModel();
            models.PageNumber = page;
            models = restaurantsService.GetRestaurants(models);
            return View(models);
        }
        public IActionResult Lowest()
        {
            List<RestaurantIndexViewModel> model = restaurantsService.GetLowestRatedRestaurants();
            return View(model);
        }

        public IActionResult Highest()
        {
            List<RestaurantIndexViewModel> model = restaurantsService.GetHighestRatedRestaurants();
            return View(model);
        }
    }
}
