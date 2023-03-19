namespace Restaurant.Services
{
    using Restaurant.Data;
    using Restaurant.Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class OrderService
    {
        private AppDbContext context;

        private static decimal total;
        public string AddItemToOrder(Item item)
        {
            using (var context = new AppDbContext())
            {
                // Check if the item exists in the database
                Item existingItem = context.Items
                    .SingleOrDefault(i => i.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));

                if (existingItem == null)
                {
                    // If the item does not exist, add it to the database
                    context.Items.Add(item);
                    context.SaveChanges();
                    existingItem = item;
                }

                // Check if the item is already in the order
                OrderItem existingOrderItem = context.OrderItems
                    .SingleOrDefault(oi => oi.ItemId == existingItem.Id && oi.OrderId == 1);

                if (existingOrderItem == null)
                {
                    // If the item is not already in the order, add it with quantity 1
                    OrderItem orderItem = new OrderItem
                    {
                        ItemId = existingItem.Id,
                        OrderId = 1,
                        Quantity = 1
                    };
                    context.OrderItems.Add(orderItem);
                }
                else
                {
                    // If the item is already in the order, increase the quantity
                    existingOrderItem.Quantity++;
                }

                context.SaveChanges();

                // Update the total price
                total += existingItem.Price;
                return $"Total Price: ${total}";
            }
        }
        //    public string CreateOrder(Item item)
        //{
        //    //bool itemFound = false;

        //    //OrderItem orderItem = new OrderItem()
        //    //{
        //    //    OrderId = orderId,
        //    //    ItemId = itemId,
        //    //    Quantity = quantity
        //    //};
        //    //context.OrderItems.Add(orderItem);
        //    //context.SaveChanges();
        //    //return "Order made!";
        //    bool itemFound = false;
        //    foreach (var orderItem in orderItem)
        //    {
        //        if (orderItem.ItemId == item.Id)
        //        {
        //            orderItem.Quantity++;
        //            itemFound = true;
        //            break;
        //        }
        //    }
        //    // if the item is not already in the order, add it with quantity 1
        //    if (!itemFound)
        //    {
        //        OrderItem orderItem = new OrderItem
        //        {
        //            Id = orderItem.Count + 1,
        //            ItemId = item.Id,
        //            OrderId = 1,
        //            Quantity = 1
        //        };
        //        context.orderItems.Add(orderItem);
        //    }
        //    // update the total price
        //    total += item.Price;
        //    totalPriceLabel.Text = $"Total Price: ${total}";
        //    // update the order items list
        //    orderItemsListBox.Items.Clear();
        //    foreach (OrderItem orderItem in orderItems)
        //    {
        //        Item orderItemName = new Item { Id = orderItem.Id, Name = item.Name, Price = item.Price };
        //        orderItemsListBox.Items.Add($"{orderItemName.Name} x {orderItem.Quantity} = ${orderItemName.Price * orderItem.Quantity}");
        //    }


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
