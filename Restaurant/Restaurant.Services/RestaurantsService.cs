namespace Restaurant.Services
{
    using Restaurant.Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Restaurant.Models.Enums;
    using System.Linq;

    public class RestaurantsService
    {
        private AppDbContext context;
        public string AddRestaurant(string name, string location)
        {
            StringBuilder sb = new StringBuilder();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(name))
            {
                sb.AppendLine($"Invalid {nameof(name)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(location))
            {
                sb.AppendLine($"Invalid {nameof(location)}!");
                isValid = false;
            }
            if (isValid)
            {
                Restaurant restaurant = new Restaurant()
                {
                    Name = name,
                    Location = location
                };
                using (context = new AppDbContext())
                {
                    context.Restaurants.Add(restaurant);
                    context.SaveChanges();
                    sb.AppendLine($"Restaurant {name} located in {location} is added!");
                }
            }
            return sb.ToString().TrimEnd();
        }
        public Restaurant GetRestaurantByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid Restaurant name!");
            }
            using (context = new AppDbContext())
            {
                Restaurant r = context.Restaurants.FirstOrDefault(x => x.Name == name);
                context.SaveChanges();
                return r;
            }
        }
        public Restaurant GetRestaurantById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Restaurants.Find(id);
            }
        }
        public string GetRestaurantInfo()
        {
            Restaurant r = null;
            using (context = new AppDbContext())
            {
                r = context.Restaurants.Find(r);
            }
            if (r != null)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine($"{nameof(Restaurant)} info: ");
                msg.AppendLine($"\tId: {r.Id}");
                msg.AppendLine($"\tName: {r.Name}");
                msg.AppendLine($"\tLocation: {r.Location}");
                msg.AppendLine($"\tType: {r.Type}");
                return msg.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Restaurant)} not found!";
            }

        }
        public string DeleteRestaurantById(int id)
        {
            using (context = new AppDbContext())
            {
                Restaurant restaurant = context.Restaurants.Find(id);
                if (restaurant == null) { return $"{nameof(Restaurant)} not found!"; }
                context.Restaurants.Remove(restaurant);
                context.SaveChanges();
                return $"{nameof(Restaurant)} {restaurant.Name} in {restaurant.Location} was deleted!";
            }
        }
        public Restaurant GetRestaurantByType()
        {
            string input = Console.ReadLine();

            if (!Enum.TryParse(input, true, out CuisineType type))
            {
                throw new ArgumentException("Invalid Restaurant type!");
            }
            using (context = new AppDbContext())
            {
                Restaurant t = context.Restaurants.FirstOrDefault(x => x.Type == type);
                context.SaveChanges();
                return t;
            }
        }
        public Restaurant GetRestaurantByLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Invalid location!");
            }
            using (context = new AppDbContext())
            {
                Restaurant r = context.Restaurants.FirstOrDefault(x => x.Location == location);
                context.SaveChanges();
                return r;
            }
        }

        public List<Restaurant> SortRestaurantsByRating(List<Restaurant> restaurants)
        {
            using (context = new AppDbContext())
            {
                return context.Restaurants.OrderByDescending(x => x.Rating).ToList();
            }
        }
    }
}
