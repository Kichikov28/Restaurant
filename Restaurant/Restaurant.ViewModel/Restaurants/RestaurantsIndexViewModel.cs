namespace Restaurant.ViewModel.Restaurants
{
    using Restaurant.ViewModel.Shared;
    using System.Collections.Generic;
    public class RestaurantsIndexViewModel:PagingViewModel
    {
        public List<RestaurantIndexViewModel> Restaurants;

        public RestaurantsIndexViewModel()
        {
            this.Restaurants = new List<RestaurantIndexViewModel>();
        }
    }
}
