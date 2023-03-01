namespace Restaurant.Services
{
    using Restaurant.Data;
    using Restaurant.Models;
    using Restaurant.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class MenuService
    {
        private AppDbContext context;

        public Menu GetMenuByName()
        {
            string input = Console.ReadLine();

            if (!Enum.TryParse(input, true, out MenuTypes type))
            {
                throw new ArgumentException("Invalid menu type!");
            }
            using (context = new AppDbContext())
            {
                Menu m = context.Menus.FirstOrDefault(x => x.Type == type);
                context.SaveChanges();
                return m;
            }
        }
        public Menu GetMenuById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Menus.Find(id);
            }
        }
    }
}
