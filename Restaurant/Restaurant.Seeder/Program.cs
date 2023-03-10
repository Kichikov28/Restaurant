namespace Restaurant.Seeder
{
    using Restaurant.Services;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static RestaurantsService restaurantsService = new RestaurantsService();
        private static ItemsService itemsService= new ItemsService();   
        public static void Main()
        {
            SeedRestaurants();
            SeedItems();
        }
        public static void SeedRestaurants()
        {
            List<string> name = new List<string>() { "Spice Palace", "Seafood Haven", "The Burger Joint", "Noodle Bar", "Tandoori Flames", "La Pizzeria", "The Steakhouse", "Sushi Spot", "The Brasserie", "The Green Garden", "Thai Terrace", "The Pasta House", "The Rustic Kitchen", "BBQ Pit" };
            List<string> location = new List<string>() { "Velingrad", "Sofia", "Plovdiv", "Varna", "Burgas", "Veliko Tarnovo", "Haskovo", "Ruse", "Stara Zagora", "Vidin", "Pazardjik", "Bansko", "Asenovgrad", "Dobrich", "Shumen", "Pernik", "Yambol", "Gabrovo", "Vratsa", "Kyustendil", "Montana", "Lovech", "Dimitrovgrad", "Gorna Oryahovitsa", "Smolyan", "Petrich", "Karlovo", "Svishtov", "Sandanski", "Asparuhovo", "Lom", "Sevlievo", "Nova Zagora", "Troyan", "Aytos", "Panagyurishte" };
            List<string> type = new List<string>() { "Italian", "Bulgarian", "Chinese", "Japanese", "Greek", "Spanish", "French", "Lebanese", "Turkey", "Indian", "Thai", "Mexican", "American", "Moroccan" };
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                int restaurantName = random.Next(0, name.Count);
                int restaurantLocation = random.Next(0, location.Count);
                double rating = Math.Round(random.NextDouble() * 8 + 2, 1);
                int restaurantType = random.Next(0, type.Count);
                Console.WriteLine($"{restaurantsService.AddRestaurant(name[restaurantName], rating, location[restaurantLocation], type[restaurantType])}");
            }
        }
        public static void SeedItems()
        {
            List<string> name = new List<string>() { "Cesar Salad", "Greek Salad", "Shopska Salad", "Ovcharska Salad", "French fries", "Fish Trout", "Chicken Soup", "Steak", "Cheesecake", "Homemade cake", "Moussaka", "Club Sandwich", "Cheeseburger", "Pasta Blognese", "Pasta Parmegiano", "Pizza Margarita", "Pizza 4 seasons", "Pizza Fashion", "Crispy chicken" };
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int itemName = random.Next(0, name.Count);
                decimal price =(decimal)Math.Round(random.NextDouble()*random.Next(20,30), 2);
                Console.WriteLine(itemsService.AddItem(name[itemName], price));
            }
        }
    }
}


