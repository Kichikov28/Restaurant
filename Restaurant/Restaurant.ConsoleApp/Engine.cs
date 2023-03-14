namespace Restaurant.ConsoleApp
{
    using System;
    using Restaurant.Data;
    using Services;
    public class Engine
    {
        private readonly RestaurantsService restaurantService = new RestaurantsService();
        private readonly ItemsService itemsService = new ItemsService();
        public Engine()
        {
            restaurantService = new RestaurantsService();
            itemsService = new ItemsService();
            Run();
        }
        public void Run()
        {
            Console.WriteLine("Welcome to the Restaurant App!");
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Get Restaurant by Name");
                    Console.WriteLine("2. Get Restaurant by ID");
                    Console.WriteLine("3. Get Restaurant by Location");
                    Console.WriteLine("4. Add Restaurant");
                    Console.WriteLine("5. Get All Restaurants Info");
                    Console.WriteLine("6. Get All Items Info");
                    Console.WriteLine("7. Add Item");
                    Console.WriteLine("8. Get Item by ID");
                    Console.WriteLine("9. Get Item by Name");
                    Console.WriteLine("10. Update Item Price");
                    Console.WriteLine("11. Remove Item by Name");
                    Console.WriteLine("12. Exit");

                    Console.Write("\nEnter your choice: ");
                    string command = Console.ReadLine();

                    switch (command)
                    {
                        case "1":
                            Console.Write("Enter restaurant name: ");
                            string name = Console.ReadLine();
                            var nameToFind = restaurantService.GetRestaurantByName(name);
                            Console.WriteLine(nameToFind.Name);
                            break;

                        case "2":
                            Console.Write("Enter restaurant ID: ");
                            int id = int.Parse(Console.ReadLine());
                            var item = restaurantService.GetRestaurantById(id);
                            Console.WriteLine($"Restaurant with Id {item.Id} is {item.Name}");
                            break;

                        case "3":
                            Console.Write("Enter restaurant location: ");
                            string location = Console.ReadLine();
                            var restaurantByLocation = restaurantService.GetRestaurantByLocation(location);

                            break;

                        case "4":
                            Console.Write("Enter restaurant name: ");
                            string restaurantName = Console.ReadLine();
                            Console.Write("Enter restaurant rating: ");
                            double rating = double.Parse(Console.ReadLine());
                            Console.Write("Enter restaurant location: ");
                            string restaurantLocation = Console.ReadLine();
                            Console.Write("Enter restaurant type: ");
                            string restaurantType = Console.ReadLine();
                            Console.WriteLine(restaurantService.AddRestaurant(restaurantName, rating, restaurantLocation, restaurantType));
                            break;

                        case "5":
                            Console.WriteLine(restaurantService.GetAllRestaurantsInfo());
                            break;
                        case "6":
                            Console.WriteLine(itemsService.GetAllItemsInfo());
                            break;

                        case "7":
                            Console.Write("Enter item name: ");
                            string itemName = Console.ReadLine();
                            Console.Write("Enter item price: ");
                            decimal itemPrice = decimal.Parse(Console.ReadLine());
                            Console.WriteLine(itemsService.AddItem(itemName, itemPrice));
                            break;

                        case "8":
                            Console.Write("Enter item ID: ");
                            int itemID = int.Parse(Console.ReadLine());
                            itemsService.GetItemById(itemID);
                            break;

                        case "9":
                            Console.Write("Enter item name: ");
                            string itemNameToSearch = Console.ReadLine();
                            itemsService.GetItemByName(itemNameToSearch);
                            break;

                        case "10":
                            Console.Write("Enter item id: ");
                            int itemId = int.Parse(Console.ReadLine());
                            Console.Write("Enter new price: ");
                            decimal newPrice = decimal.Parse(Console.ReadLine());
                            Console.WriteLine(itemsService.UpdateItemPrice(itemId, newPrice));
                            break;

                        case "11":
                            Console.Write("Enter item name to remove: ");
                            string itemNameToRemove = Console.ReadLine();
                            Console.WriteLine(itemsService.RemoveItemByName(itemNameToRemove));
                            break;

                        case "12":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
