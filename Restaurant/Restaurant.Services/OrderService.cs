using Restaurant.Data;
using Restaurant.Models;
using System;
namespace Restaurant.Services
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class OrderService
    {
        private AppDbContext context;
        public string CreateOrder(int restaurantId, int itemId, double quantity)
        {
            // find the item by id
            Item item = context.Items.Find(itemId);
            if (item == null)
            {
                return "Item not found";
            }

            // find the restaurant by id
            var restaurant = context.Restaurants.Find(restaurantId);
            if (restaurant == null)
            {
                return "Restaurant not found";
            }

            // check if the restaurant has the item in their menu
            bool itemInMenu = context.MenuItems.Any(mi => mi.Menu.RestaurantId == restaurantId && mi.ItemId == itemId);
            if (!itemInMenu)
            {
                return "Item is not available in this restaurant's menu";
            }

            // create a new order
            Order order = new Order()
            {
                RestaurantId = restaurantId,
                Date = DateTime.Now
            };

            // add the order item to the order
            OrderItem orderItem = new OrderItem()
            {
                ItemId = itemId,
                Quantity = quantity
            };
            order.OrderItems.Add(orderItem);

            // save the changes to the database
            context.Orders.Add(order);
            context.SaveChanges();

            return "Order created!";
        }
        public List<string> GetFromRestaurant()
        {
            return this.context.Restaurants.
                OrderBy(x => x.Id)
                .Select(x => $"{x.Id} - {x.Name}")
                .ToList();
        }
        public List<string> GetToRestaurants(int restaurantid)
        {
            return this.context.Restaurants
                .Where(x => x.Id != restaurantid)
                 .OrderBy(x => x.Id)
                .Select(x => $"{x.Id} - {x.Name}").ToList();
        }
    }
}
