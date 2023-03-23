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
        public string CreateOrder(int restaurantId, int customerId,  List<int> itemId)
        {
            using (context = new AppDbContext())
            {
                Order order = new Order()
                {
                    RestaurantId = restaurantId,
                    CustomerId = customerId
                };

                foreach (var item in itemId)
                {
                    order.OrderItems.Add(new OrderItem { ItemId = item ,Quantity=1});
                }

                context.Orders.Add(order);
                context.SaveChanges();
                return $"Your order is on your way.";
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

        //public void UpdateOrderTotalPrice(int orderId, decimal totalPrice)
        //{
        //    var order = context.Orders.FirstOrDefault(o => o.Id == orderId);

        //    if (order == null)
        //    {
        //        throw new ArgumentException($"Order with ID {orderId} not found.");
        //    }

        //    order.TotalPrice = totalPrice;
        //    context.SaveChanges();
        //}
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
