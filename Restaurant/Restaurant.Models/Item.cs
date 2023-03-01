namespace Restaurant.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<MenuItems> MenuItems { get; set; } = new List<MenuItems>();
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
