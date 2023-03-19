namespace Restaurant.Services
{
    using Restaurant.Data;
    using Restaurant.Models;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class OrderService
    {
        private AppDbContext context;
        public string CreateOrder(int orderId, int itemId, double quantity)
        {
            bool itemFound = false;

            OrderItem orderItem = new OrderItem()
            {
                OrderId = orderId,
                ItemId = itemId,
                Quantity = quantity
            };
            foreach (var orderItem in orderItem)
            {
                if (orderItem.ItemId == item.Id)
                {
                    orderItem.Quantity++;
                    itemFound = true;
                    break;
                }
            }
            // if the item is not already in the order, add it with quantity 1
            if (!itemFound)
            {
                OrderItem orderItem = new OrderItem
                {
                    Id = orderItems.Count + 1,
                    ItemId = item.Id,
                    OrderId = 1,
                    Quantity = 1
                };
                orderItems.Add(orderItem);
            }
            // update the total price
            total += item.Price;
            totalPriceLabel.Text = $"Total Price: ${total}";
            // update the order items list
            orderItemsListBox.Items.Clear();
            foreach (OrderItem orderItem in orderItems)
            {
                Item orderItemName = new Item { Id = orderItem.Id, Name = item.Name, Price = item.Price };
                orderItemsListBox.Items.Add($"{orderItemName.Name} x {orderItem.Quantity} = ${orderItemName.Price * orderItem.Quantity}");
            }
            context.OrderItems.Add(orderItem);
            context.SaveChanges();
            return "Your order is sent!";
        }

        public List<string> GetItems()
        {
            List<string> itemsInfo;
            using (context = new AppDbContext())
            {
                itemsInfo = this.context.Items.
                     OrderBy(x => x.Id)
                     .Select(x => $"{x.Id} - {x.Name}")
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
