namespace Restaurant.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Menu
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<MenuItems> MenuItems { get; set; } = new List<MenuItems>();
    }
}
