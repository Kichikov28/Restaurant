namespace Restaurant.Services
{
    using Microsoft.EntityFrameworkCore;
    using Restaurant.Data;
    using Restaurant.Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading;

    public class OrderService
    {
        private AppDbContext context;

        private static decimal total;

        public int CreateOrder(int restaurantId, int customerId, decimal totalPrice)
        {
            using (context = new AppDbContext())
            {
                var order = new Order
                {
                    Date = DateTime.Now,
                    RestaurantId = restaurantId,
                    TotalPrice = totalPrice,
                    CustomerId = customerId
                };

                context.Orders.Add(order);
                context.SaveChanges();
                return order.Id;
            }
        }

        public void AddItemToOrder(int itemId, int orderId, int quantity)
        {
            using (context = new AppDbContext())
            {
                var orderItem = new OrderItem
                {
                    ItemId = itemId,
                    OrderId = orderId,
                    Quantity = quantity
                };

                context.OrderItems.Add(orderItem);
                context.SaveChanges();
            }
        }

        public string AddOrderItems(int orderId, List<int> itemId)
        {
            StringBuilder sb = new StringBuilder();
            using (context = new AppDbContext())
            {
                Order order = context.Orders.Find(orderId);
                if (order == null)
                {
                    sb.AppendLine($"{nameof(Order)} not found!");
                    return sb.ToString().TrimEnd();
                };
                List<Item> items = new List<Item>();
                foreach (var id in itemId)
                {
                    Item item = context.Items.Find(id);
                    if (item!=null)
                    {
                        items.Add(item);
                    }
                }
                if (items.Count==0)
                {
                    sb.AppendLine($"{nameof(Item)}s not found!");
                    return sb.ToString().TrimEnd();
                }
                sb.AppendLine($"{orderId} {order.RestaurantId} {order.Date}");
                foreach (var item in items)
                {
                    context.OrderItems.Add(new OrderItem
                    {
                        Order = order,
                        Item = item
                    });
                    sb.AppendLine($"\t{item.Name} {item.Price}");
                }
                context.SaveChanges();
                return sb.ToString().TrimEnd();
            }
        }
        public decimal GetItemPrice(int itemId)
        {
            var item = context.Items.FirstOrDefault(i => i.Id == itemId);

            if (item == null)
            {
                throw new ArgumentException($"Item with ID {itemId} not found.");
            }

            return item.Price;
        }

        public void UpdateOrderTotalPrice(int orderId, decimal totalPrice)
        {
            var order = context.Orders.FirstOrDefault(o => o.Id == orderId);

            if (order == null)
            {
                throw new ArgumentException($"Order with ID {orderId} not found.");
            }

            order.TotalPrice = totalPrice;
            context.SaveChanges();
        }
        public List<string> GetItems()
        {
            List<string> itemsInfo;
            using (context = new AppDbContext())
            {
                itemsInfo = this.context.Items.
                     OrderBy(x => x.Id)
                     .Select(x => $"{x.Id} - {x.Name} - {x.Price}")
                     .ToList();
            }
            return itemsInfo;

        }
        public List<string> GetFromRestaurant()
        {
            List<string> restaurantsInfo;
            using (context = new AppDbContext())
            {
                restaurantsInfo = this.context.Restaurants.
                     OrderBy(x => x.Id)
                     .Select(x => $"{x.Id} - {x.Name}")
                     .ToList();
            }
            return restaurantsInfo;

        }
        public List<string> GetToRestaurants(int restaurantid)
        {
            return this.context.Restaurants
                .Where(x => x.Id == restaurantid)
                 .OrderBy(x => x.Id)
                .Select(x => $"{x.Id} - {x.Name}").ToList();
        }
    }
}
