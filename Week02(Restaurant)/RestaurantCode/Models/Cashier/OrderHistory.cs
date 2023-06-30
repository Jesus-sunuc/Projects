public class OrderHistory
{
    public List<CustomerOrder> CustomerOrders { get; }

    public OrderHistory()
    {
        CustomerOrders = new List<CustomerOrder>();
    }
}