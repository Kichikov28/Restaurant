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
        public string AddItem(string name, decimal price)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine($"Invalid {nameof(name)}!");
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
                    Name = name,
                    Price = price
                };
                using (context = new AppDbContext())
                {
                    context.Items.Add(item);
                    context.SaveChanges();
                    message.AppendLine($"Item {name} which costs {price} leva is added!");
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
        public Item GetItemByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid Restaurant name!");
            }
            using (context = new AppDbContext())
            {
                Item item = context.Items.FirstOrDefault(x => x.Name == name);
                return item;
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
        public List<string> GetItemsBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Items
                    .Skip((page - 1) * count)
                    .Take(count)
                    .Select(x => $"{x.Id} - {x.Name} has price: {x.Price}")
                    .ToList();
            }
            return list;
        }
        public string GetItemInfoById(int id)
        {
            Item item = null;
            using (context = new AppDbContext()) 
            {
            item =context.Items.Find(id);
                if (item!=null)
                {
                    StringBuilder message = new StringBuilder();
                    message.AppendLine($"{nameof(Item)} info: ");
                    message.AppendLine($"\tId: {item.Id}");
                    message.AppendLine($"\tName: {item.Name}");
                    message.AppendLine($"\tPrice: {item.Price}");
                    return message.ToString().TrimEnd();
                }
                else
                {
                    return $"{nameof(Item)} not found!";
                }
            }
        }
        public string GetAllItemsInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"Name",-20} | {"Price",-3}|";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Item> items = context.Items
                    .Skip((page - 1) * count)
                    .Take(count)
                    .ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var i in items)
                {
                    string info = $"| {i.Id,-4} | {i.Name,-20} | {i.Price,-3}|";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Items.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();
        }
        public int GetItemsPagesCount(int count = 10)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Items.Count() / (double)count);
            }
        }
        public List<Item> SortItemByPrice(List<Item> items)
        {
            using (context = new AppDbContext())
            {
                return context.Items.OrderBy(x => x.Price).ToList();
            }
        }
        public List<Item> SortItemsByName()
        {
            using (context = new AppDbContext())
            {
                return context.Items.OrderBy(x => x.Name).ToList();
            }
        }
        public List<Item> ReverseSortItemByName()
        {
            using (context=new AppDbContext())
            {
                return context.Items.OrderByDescending(x => x.Name).ToList();
            }
        }
        public List<Item> ReverseSortItemByPrice()
        {
            using (context=new AppDbContext())
            {
                return context.Items.OrderByDescending(x => x.Price).ToList();
            } 
        }
        public string RemoveItemById(int id)
        {
            using (context = new AppDbContext())
            {
                Item item = context.Items.Find(id);
                if (item == null) { return $"{nameof(Item)} not found!"; }
                context.Items.Remove(item);
                context.SaveChanges();
                return $"{nameof(Restaurant)} {item.Name} was deleted!";
            }
        }
    }
}