namespace Restaurant.Models
{
    using System;
    using System.Collections.Generic;
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RestaurantId { get; set; }
        public string Adress { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
