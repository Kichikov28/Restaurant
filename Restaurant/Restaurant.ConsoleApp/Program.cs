namespace Restaurant.ConsoleApp
{
    using System;
    using Restaurant.Services;
    
    public class Program
    {
        static void Main()
        {
            RestaurantsService service = new RestaurantsService();
            string type = "Chinese";
            //Console.WriteLine(service.AddRestaurant(name, rating, location, type));

            Console.WriteLine(service.GetRestaurantByTypeConsole(type)); 
           
        }
    }
}
