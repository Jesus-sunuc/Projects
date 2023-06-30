public class CustomerQueue
{
    public List<Customer> Customers { get; }
    public CustomerQueue()
    {
        Customers = new List<Customer>();
    }

    public Customer GetCustomerToServe()
    {
        var customer = Customers.First();
        Customers.RemoveAt(0);
        return customer;
    }
}