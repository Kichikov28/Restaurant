namespace Restaurant.ConsoleApp
{
    using System;
    using System.Text;
    using Services;
    public class Engine
    {
        private RestaurantsService restaurantService = new RestaurantsService();
        private ItemsService itemsService = new ItemsService();
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
                    Console.Clear();
                    Menu();
                    Console.Write("\nEnter your choice: ");
                    string command = Console.ReadLine();
                    switch (command)
                    {
                        case "0":
                            return;
                        case "1":
                            GetRestaurantByName();
                            break;
                        case "2":
                            GetRestaurantById();
                            break;
                        case "3":
                            GetRestaurantByLocation();
                            break;
                        case "4":
                            AddRestaurant();
                            break;
                        case "5":
                            AllRestaurantsInfo();
                            break;
                        case "6":
                            AllItemsInfo();
                            break;
                        case "7":
                            AddItem();
                            break;
                        case "8":
                            GetItemById();
                            break;
                        case "9":
                            GetItemByName();
                            break;
                        case "10":
                            UpdateItemPrice();
                            break;
                        case "11":
                            RemoveItemByName();
                            break;
                        case "12":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid input! Please try again.");
                            PressKey();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    PressKey();
                }

            }
        }
        private void RemoveItemByName()
        {
            Console.Write("Enter item name to remove: ");
            string itemNameToRemove = Console.ReadLine();
            Console.WriteLine(itemsService.RemoveItemByName(itemNameToRemove));
            PressKey();
        }
        private void UpdateItemPrice()
        {
            Console.Write("Enter item id: ");
            int itemId = int.Parse(Console.ReadLine());
            Console.Write("Enter new price: ");
            decimal newPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine(itemsService.UpdateItemPrice(itemId, newPrice));
            PressKey();
        }
        private void GetItemByName()
        {
            Console.Write("Enter item name: ");
            string itemNameToSearch = Console.ReadLine();
            var itemName = itemsService.GetItemByName(itemNameToSearch);
            Console.WriteLine($"Item {itemName.Name} has price {itemName.Price}");
            PressKey();
        }
        private void GetItemById()
        {
            Console.Write("Enter item ID: ");
            int itemID = int.Parse(Console.ReadLine());
            var item = itemsService.GetItemById(itemID);
            Console.WriteLine($"Item with this id is {item.Name} and cost {item.Price}.");
            PressKey();
        }
        private void AddItem()
        {
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter item price: ");
            decimal itemPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine(itemsService.AddItem(itemName, itemPrice));
            PressKey();
        }
        private void AllItemsInfo()
        {
            int currentPage = 1;
            int pageCount = itemsService.GetItemsPagesCount();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Items list: ");
                string info = itemsService.GetAllItemsInfo(currentPage);
                Console.WriteLine(info);
                Console.WriteLine("Commands: 0:Back, 1:Previous page, 2:Next page ");
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        if (currentPage > 1) { currentPage--; }
                        break;
                    case "2":
                        if (currentPage < pageCount) { currentPage++; }
                        break;
                }
            }
        }
        private void AllRestaurantsInfo()
        {
            int currentPage = 1;
            int pageCount = restaurantService.GetRestaurantPagesCount();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Items list: ");
                string info = restaurantService.GetAllRestaurantsInfo(currentPage);
                Console.WriteLine(info);
                Console.WriteLine("Commands: 0:Back, 1:Previous page, 2:Next page ");
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        if (currentPage > 1) { currentPage--; }
                        break;
                    case "2":
                        if (currentPage < pageCount) { currentPage++; }
                        break;
                }
            }
        }
        private void AddRestaurant()
        {
            Console.Write("Enter restaurant name: ");
            string restaurantName = Console.ReadLine();
            Console.Write("Enter restaurant rating: ");
            double rating = double.Parse(Console.ReadLine());
            Console.Write("Enter restaurant location: ");
            string restaurantLocation = Console.ReadLine();
            Console.Write("Enter restaurant type: ");
            string restaurantType = Console.ReadLine();
            Console.WriteLine(restaurantService.AddRestaurant(restaurantName, rating, restaurantLocation, restaurantType));
            PressKey();
        }
        private void GetRestaurantByLocation()
        {
            Console.Write("Enter restaurant location: ");
            string location = Console.ReadLine();
            var restaurantByLocation = restaurantService.GetRestaurantByLocation(location);
            Console.WriteLine($"{restaurantByLocation.Name} located in {location} has {restaurantByLocation.Rating} rating.");
            PressKey();
        }
        private void GetRestaurantById()
        {
            Console.Write("Enter restaurant ID: ");
            int id = int.Parse(Console.ReadLine());
            var item = restaurantService.GetRestaurantById(id);
            Console.WriteLine($"Restaurant with Id {item.Id} is {item.Name}");
            PressKey();
        }
        private static void PressKey()
        {
            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();
        }
        private void GetRestaurantByName()
        {
            Console.Write("Enter restaurant name: ");
            string name = Console.ReadLine();
            var nameToFind = restaurantService.GetRestaurantByName(name);
            Console.WriteLine($"Restaurant {nameToFind.Name} has id {nameToFind.Id}, located in {nameToFind.Location}");
            PressKey();
        }
        public void Menu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Get Restaurant by Name");
            sb.AppendLine($"\t2: Get Restaurant by ID");
            sb.AppendLine($"\t3: Get Restaurant by Location");
            sb.AppendLine($"\t4: Add Restaurant");
            sb.AppendLine($"\t5: Get All Restaurants Info");
            sb.AppendLine($"\t6: Get All Items Info");
            sb.AppendLine($"\t7: Add Item");
            sb.AppendLine($"\t8: Get Item by ID");
            sb.AppendLine($"\t9: Get Item by Name");
            sb.AppendLine($"\t10: Update Item Price");
            sb.AppendLine($"\t11: Remove Item by Name");
            sb.AppendLine($"\t12: Exit");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
