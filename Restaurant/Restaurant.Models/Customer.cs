namespace Restaurant.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        public int OrderId { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
