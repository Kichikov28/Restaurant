namespace Restaurant.Services
{
    using Restaurant.Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class RestaurantsService
    {
        private AppDbContext context;
        public string AddRestaurant(string name, double rating, string location, string type)
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
            if (string.IsNullOrWhiteSpace(type))
            {
                sb.AppendLine($"Invalid {nameof(type)}!");
                isValid = false;
            }
            if (rating < 2)
            {
                sb.AppendLine($"Invalid {nameof(rating)}!");
                isValid = false;
            }
            if (isValid)
            {
                Restaurant restaurant = new Restaurant()
                {
                    Name = name,
                    Rating = rating,
                    Location = location,
                    Type = type
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
        public string UpdateRestaurantRating(int id, double newRating)
        {
            using (context = new AppDbContext())
            {
                Restaurant restaurant = context.Restaurants.Find(id);
                if (restaurant == null) { return $"{nameof(Restaurant)} not found!"; }
                if (newRating < 2 || newRating > 10) { return "Invalid new rating!"; }
                restaurant.Rating = newRating;
                context.Restaurants.Update(restaurant);
                context.SaveChanges();
                return $"{nameof(Restaurant)} {restaurant.Name} has new rating: {newRating}";
            }
        }
        public List<string> GetRestaurantsBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Restaurants
                    .Skip((page - 1) * count)
                    .Take(count)
                    .Select(x => $"{x.Id} - {x.Name} has {x.Rating} rating")
                    .ToList();
            }
            return list;
        }

        public int GetRestaurantPagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Restaurants.Count() / (double)count);
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
        public string GetRestaurantByTypeConsole(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Invalid restaurant type!");
            }
            using (context = new AppDbContext())
            {
                Restaurant t = context.Restaurants.FirstOrDefault(x => x.Type == type);
                return t.Name;
            }
        }
        public Restaurant GetRestaurantByType(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Invalid restaurant type!");
            }
            using (context = new AppDbContext())
            {
                Restaurant t = context.Restaurants.FirstOrDefault(x => x.Type == type);
                return t;
            }
        }
        public Restaurant GetRestaurantByLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
            {
                throw new ArgumentException("Invalid restaurant location!");
            }
            using (context = new AppDbContext())
            {
               Restaurant r = context.Restaurants.FirstOrDefault(x => x.Location == location);
                return r;
            }
        }

        public List<Restaurant> SortRestaurantsByRating(List<Restaurant> restaurants)
        {
            using (context = new AppDbContext())
            {
                return context.Restaurants.OrderBy(x => x.Rating).ToList();
            }
        }
        public List<Restaurant> ReverseSortRestaurantsByRating(List<Restaurant> restaurants)
        {
            using (context = new AppDbContext())
            {
                return context.Restaurants.OrderByDescending(x => x.Rating).ToList();
            }
        }
    }
}
