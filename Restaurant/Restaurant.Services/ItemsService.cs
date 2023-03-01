using System.Reflection;

namespace Restaurant.Services
{
    using Restaurant.Data;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class ItemsService
    {
        private AppDbContext context;
        public string AddItem(int id, string name, decimal price)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (id < 0)
            {
                message.AppendLine($"Invalid {nameof(id)}!");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine($"Invalid {nameof(id)}!");
                isValid = false;
            }
            if (price < 0)
            {
                message.AppendLine($"Invalid {nameof(price)}!");
                isValid = false;
            }

            if (isValid)
            {
                Item item = new Item()
                {
                    Id = id,
                    Name = name,
                    Price = price
                };

                using (context = new AppDbContext())
                {
                    context.Items.Add(item);
                    context.SaveChanges();
                    message.AppendLine($"Item {id} - {name} is added!");
                }
            }
            return message.ToString().TrimEnd();
        }
        public Item GetItemById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Items.Find(id);
            }
        }
        public string UpdateItemPrice(int id, decimal newPrice)
        {
            using (context = new AppDbContext())
            {
                Item item = context.Items.Find(id);
                if (item == null)
                {
                    return $"{nameof(Item)} not found!";
                }
                if (newPrice < 0)
                {
                    return $"Invalid new Price!";
                }
                item.Price = newPrice;
                context.Items.Update(item);
                context.SaveChanges();
                return $"{nameof(Item)} {item.Name} has new price: {newPrice}";
            }
        }
        public string RemoveItemByName(string name)
        {
            using (context = new AppDbContext())
            {
                Item item = context.Items.FirstOrDefault(x => x.Name == name);
                if (item == null)
                {
                    return $"{nameof(item)} not found!";
                }
                context.Items.Remove(item);
                context.SaveChanges();
                return $"{nameof(item)} {item.Name} was deleted!";
            }
        }
    }
}