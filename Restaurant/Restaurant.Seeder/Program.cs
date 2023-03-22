namespace Restaurant.Seeder
{
    using Restaurant.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static RestaurantsService restaurantsService = new RestaurantsService();
        private static ItemsService itemsService = new ItemsService();
        private static MenuService menuService = new MenuService();
        private static CustomerService customerService= new CustomerService();
        public static void Main()
        {
            SeedRestaurants();
            SeedItems();
            SeedMenus();
            SeedCustomers();
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
                decimal price = (decimal)Math.Round(random.NextDouble() * random.Next(20, 30), 2);
                Console.WriteLine(itemsService.AddItem(name[itemName], price));
            }
        }
        public static void SeedMenus()
        {
            List<string> type = new List<string> { "Breakfast", "Lunch", "Dinner" };
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int menuType = random.Next(0, type.Count);
                int restaurantId = random.Next(1, 50);
                Console.WriteLine(menuService.CreateMenu(type[menuType], restaurantId));
            }
        }
        public static void SeedCustomers()
        {
            List<string> names = new List<string>() { "Ethan Larson", "Olivia Kim", "Lucas Chen", "Ava Patel", "Benjamin Wright", "Charlotte Nguyen", "Jameson Kim", "Madison Singh", "Noah Davis", "Sophia Garcia", "Alexander Johnson", "Isabella Lee", "William Rodriguez", "Mia Hernandez", "Michael Thompson", "Emma Martinez", "Elijah Brown", "Abigail Wilson", "Gabriel Gonzalez", "Emily Anderson" };
            List<string> adresses = new List<string> { "45 Oak Street, Boston, MA 02108", "7832 4th Avenue, Seattle, WA 98108", "609 Main Street, Dallas, TX 75202", "1723 Elm Street, Denver, CO 80202", "912 Park Avenue, New York, NY 10075", "3815 Broadway, San Francisco, CA 94109", "1122 Market Street, Wilmington, DE 19801", "815 Washington Street, Portland, ME 04101", "1875 Michigan Avenue, Miami Beach, FL 33139", "200 Peachtree Street, Atlanta, GA 30303" };
            List<string> phoneNumbers = new List<string> { "0897654892", "0891254832", "0872054891", "0897725192", "0897657210", "0897654828", "0897612345", "0897731897", "0897654821", "0897654842" };
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int customerName = random.Next(0, names.Count);
                int customerAdress = random.Next(0, adresses.Count);
                int customerPhoneNumber= random.Next(0, phoneNumbers.Count);
                Console.WriteLine(customerService.AddCustomer(names[customerName], adresses[customerAdress], phoneNumbers[customerPhoneNumber]));
            }
        }
    }
}


