namespace backend.Models;

public class Order
{
    public int Id { get; set; }
    public int TableNumber { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Received;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<OrderItem> Items { get; set; } = new();
}
