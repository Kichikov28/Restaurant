namespace Restaurant.Services
{
    using Restaurant.Data;
    using Restaurant.Models;
    using System;
    using System.Linq;
    public class MenuService
    {
        private AppDbContext context;
        public Menu GetMenuByName(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Invalid menu type!");
            }
            using (context = new AppDbContext())
            {
                Menu m = context.Menus.FirstOrDefault(x => x.Type == type);
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
