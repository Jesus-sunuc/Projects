public class CustomerOrder
{
    public Transaction Transaction { get; }
    public List<MenuItem> MenuItems { get; }
    public CustomerOrder(Transaction transaction, List<MenuItem> menuItems)
    {
        Transaction = transaction;
        MenuItems = menuItems;
    }
}