namespace Restaurant.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public double Quantity { get; set; }
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
