namespace Restaurant.Seeder
{
    using Restaurant.Services;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static RestaurantsService restaurantsService = new RestaurantsService();
        public static void Main()
        {
            SeedRestaurants();
        }
        public static void SeedRestaurants()
        {
            List<string> name = new List<string>() { "Spice Palace", "Seafood Haven", "The Burger Joint", "Noodle Bar", "Tandoori Flames", "La Pizzeria", "The Steakhouse", "Sushi Spot", "The Brasserie", "The Green Garden", "Thai Terrace", "The Pasta House", "The Rustic Kitchen", "BBQ Pit" };
            List<string> location = new List<string>() { "Velingrad", "Sofia", "Plovdiv", "Varna", "Burgas", "Veliko Tarnovo", "Haskovo","Ruse","Stara Zagora","Vidin", "Pazardjik", "Bansko", "Asenovgrad", "Dobrich", "Shumen", "Pernik", "Yambol", "Gabrovo", "Vratsa", "Kyustendil", "Montana", "Lovech", "Dimitrovgrad", "Gorna Oryahovitsa", "Smolyan", "Petrich", "Karlovo", "Svishtov", "Sandanski", "Asparuhovo", "Lom", "Sevlievo", "Nova Zagora", "Troyan", "Aytos", "Panagyurishte" };
            List<string> type = new List<string>() { "Italian", "Bulgarian", "Chinese", "Japanese", "Greek","Spanish", "French", "Lebanese", "Turkey", "Indian", "Thai", "Mexican", "American", "Moroccan" };
            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                int restaurantName = random.Next(0, name.Count);
                int restaurantLocation = random.Next(0, location.Count);
                double rating = Math.Round(random.NextDouble() * 8 + 2, 1);
                int restaurantType = random.Next(0, type.Count);
                Console.WriteLine($"{restaurantsService.AddRestaurant(name[restaurantName], rating, location[restaurantLocation], type[restaurantType])}");
            }
        }
    }
}


