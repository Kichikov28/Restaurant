namespace Restaurant.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    public class AppDbContext : DbContext
    {
        private const string connectionString = @"Server=DESKTOP-TAARGOA; Initial Catalog=RestaurantEf; Integrated Security=true; Trusted_Connection =true";
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<MenuItems> MenuItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItems>(option =>
            {
                option.HasKey(x => new { x.MenuId, x.ItemId });
            });
            modelBuilder.Entity<Restaurant>(option =>
            {
                option.Property(x => x.Name)
                    .IsRequired();

                option.Property(x => x.Location)
                    .IsRequired();
            });
            modelBuilder.Entity<Customer>(option =>
            {
                option.Property(x => x.Name)
                   .IsRequired();

                option.HasIndex(x => x.PhoneNumber)
                .IsUnique(true);
            });
            modelBuilder.Entity<Menu>(option =>
            {
                option.Property(x => x.Type)
                    .IsRequired();

                option.HasOne(x => x.Restaurant)
                    .WithMany(x => x.Menus)
                    .HasForeignKey(x => x.RestaurantId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Item>(option =>
            {
                option.Property(x => x.Name)
                .IsRequired();
            });
        }
    }


}
